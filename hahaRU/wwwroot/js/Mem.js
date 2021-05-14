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
        }
    }
})
class Text {
    constructor(text = '', x = 0, y = 0) {
        this.fillStyle = "#263871";
        this.textBaseline = "top";
        this.size = 50;
        this.font = "AvantGardeCTT";
        this.x = x;
        this.y = y;
        this.text = text;
        this.type = "text";
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
        if (src == this._src) return this._img;
        let me = this;
        return new Promise((resolve, reject) => {
            let img = new Image();
            img.src = src;
            me._src = src;
            img.onload = data => resolve(img)
        })
    }
    constructor(src = '', x = 0, y = 0) {
        this.x = x;
        this.y = y;
        this.src = src;
        this.type = "Image";
        this.name = "test"
        this._img = null;
        this._src = null;
    }
    async draw(ctx) {
        this._img = await this.loadImg(this.src);
        ctx.drawImage(this._img, this.x, this.y)
    }
}
class MemGenerator{
    constructor() {
        this.el = document.getElementById("mem");
        this.ctx = this.el.getContext("2d")
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
    async memCreate() {

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