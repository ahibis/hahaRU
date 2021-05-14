let vm = new Vue({
    el: "#app",
    data: {
        Posts: [],
        texts: [],
        imgs: [],
        type: "обычный",
        types: ["обычный","демотиватор","многокартиночный"]
    },
    methods: {
        changeLike: async function (postId) {
            console.log(postId)
            let data = await api("changeContentLiked", { postId: postId, type: "mem"  });
            console.log(data)
            if (data.value) {
                let post = this.Posts.filter(post => post.id == postId)[0]
                post.isLiked = data.value.isliked;
                post.likesCount = data.value.likesCount
            }
        },
        changeDisLike: async function (postId) {
            let data = await api("changeContentDisLiked", { postId: postId, type:"mem" });
            console.log(data)
            if (data.value) {
                let post = this.Posts.filter(post => post.id == postId)[0]
                post.isDisliked = data.value.isDisliked;
                post.dislikesCount = data.value.dislikesCount
            }
        },
        input:async function(){
            await generator.draw();
        }
    }
})
class Text {
    constructor(text = '', x = 0, y = 0) {
        //this.fillStyle = "#263871";
        this.fillStyle = "#FFFFFF";
        this.textBaseline = "top";
        this.size = 50;
        this.font = "Impact";
        this.x = x;
        this.y = y;
        this.text = text;
        this.type = "text";
    }
    get width(){
        return this.size*this.text.length;
    }
    async draw(ctx) {
        ctx.fillStyle = this.fillStyle;
        ctx.textBaseline = "top";
        ctx.font = `${this.size}px ${this.font}`;
        ctx.fillText(this.text, this.x, this.y);
    }
}
class Img {
    loadImg(src) {
        if (src == this._src) if(this._img)return  this._img;
        let me = this;
        return new Promise((resolve, reject) => {
            let img = new Image();
            img.src = src;
            //img.width=me.width;
            me._src = src;
            this._img=img;
            img.onload = data => {
                
                resolve(img);
            }
        })
    }
    constructor(src = '', x = 0, y = 0,width=100) {
        this.x = x;
        this.y = y;
        this.src = src;
        this.type = "Image";
        this.name = "test";
        this.width=width;
        this.imgWidth=100;
        this.imgHeight=100;
        this.height=100;
        this._img = null;
        this._src = null;
        let me=this;
    }
    async getHeight(){
        let img=await this.loadImg(this.src);
        this.imgWidth=img.width;
        this.imgHeight=img.height;
        this.height=this.width*img.height/img.width;
        return this.height;
    }
    async draw(ctx) {
        this._img = await this.loadImg(this.src);
        let img=this._img;
        ctx.drawImage(this._img, this.x, this.y,this.width,this.width*img.height/img.width)
    }
}
class MemGenerator{
    constructor() {
        this.el = document.getElementById("mem");
        this.ctx = this.el.getContext("2d")
        this.updateMove();
        this.width=600;
        this.changeType(vm.type).then()
    }
    updateMove(){
        let el=this.el;
        let x=0;
        let y=0;
        let tx=0;
        let ty=0;
        let target=null;
        let me=this;
        $(el).mousedown(function (e) {
            let mouseX=e.offsetX;
            let mouseY=e.offsetY;
            for(let i in vm.texts){
                let text=vm.texts[i];
                let x1=text.x;
                let y1=text.y;
                let x2=text.x+text.width;
                let y2=text.y+text.size;
                if(mouseX>=x1 && mouseX<=x2 && mouseY>=y1 && mouseY<=y2){
                    target=text;
                    tx=target.x;
                    ty=target.y;
                    x=mouseX;
                    y=mouseY;
                }
            }
        })
        $(el).mousemove(async function (e) {
            let mouseX=e.offsetX;
            let mouseY=e.offsetY;
            for(let i in vm.texts){
                let text=vm.texts[i];
                let x1=text.x;
                let y1=text.y;
                let x2=text.x+text.width;
                let y2=text.y+text.size;
                if(mouseX>=x1 && mouseX<=x2 && mouseY>=y1 && mouseY<=y2){
                    if(target){
                        target.x=tx+mouseX-x;
                        target.y=ty+mouseY-y;
                        await me.draw()
                    }
                }
            }
        })
        $(el).mouseup(function (e) {
            let mouseX=e.offsetX;
            let mouseY=e.offsetY;
            for(let i in vm.texts){
                let text=vm.texts[i];
                let x1=text.x;
                let y1=text.y;
                let x2=text.x+text.width;
                let y2=text.y+text.size;
                target=null;
                if(mouseX>=x1 && mouseX<=x2 && mouseY>=y1 && mouseY<=y2){
                    
                }
            }
        });
    }
    get width(){
        return this._width
    }
    set width(w){
         this._width=w;
         this.el.width=w;
    }
    get height(){
        return this._height;
    }
    set height(w){
        this._height=w;
         this.el.height=w;
    }
    canvasToImg(ctx) {
        let src = ctx.toDataURL();
        let img = new Image();
        img.src = src;
        return img
    }
    saveImage(image) {
        let link = document.createElement("a");
        link.setAttribute("href", image.src);
        link.setAttribute("download", "certificate");
        link.click();
    }
    downImg() {
        this.saveImage(this.certificate);
    }
    async changeType(type){
        let texts=vm.texts.map(e=>e.text);
        let imgs=vm.imgs.map(e=>e.src)
        vm.texts=[];
        vm.imgs=[];
        if(type=="обычный"){
            let img=new Img("/img/memImgs/Putin.jpg",0,0,this.width)
            this.height=await img.getHeight();
            let text=new Text("Новый текст",this.width*0.1,this.height*0.7)
            vm.imgs.push(img);
            vm.texts.push(text);
            this.draw().then();
            return;
        }
    }
    async memCreate() {

    }
    async draw() {
            for(let img in vm.imgs){
                await vm.imgs[img].draw(this.ctx)
            }
            for(let text in vm.texts){
                await vm.texts[text].draw(this.ctx)
            }
        }
}

generator = new MemGenerator();

let lastPost = 0;
async function load() {
    let posts = await api("getContents", { Offset: lastPost, Count: 20, type:"mem"  });
    lastPost += posts.length;
    vm.Posts = posts;
}
load().then();