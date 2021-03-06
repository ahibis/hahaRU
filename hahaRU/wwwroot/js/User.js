let vm = new Vue({
    el: "#app",
    data: {
        Login: "НЕСУЩЕСТВУЮЩАЯ СТРАНИЦА",
        Date: "2021-04-15",
        Status: "ПОРА ЗАРЕГАТЬСЯ",
        FavoriteJoke: "ГРУСТНО ШО ЕЕ НЕ СУЩЕСВУЕТ",
        VkLink: "ссылка на вк",
        InstaLink: "ссылка на instagram",
        OK: "ссылка на одноклассники",
        Id: 0,
        Likes: 0,
        DisLikes: 0,
        Posts: [],
        User: {},
        edit: 1,
        AvatarSrc: "/img/logo.png",
        text: ""
    },
    methods: {
        sendPost:async function() {
            console.log(await api("sendPost", { Text: this.text, Date: new Date().toJSON().split("T")[0] }));
            this.text = "";
            let posts = await api("getPosts", { UserId: my.Id, Offset: 0, Count: 1 });
            console.log(posts);
            lastPost += posts.length;
            vm.Posts = [...posts, ...vm.Posts];
        },
        avaChange: async function () {
            if (!(ID == 0 || this.Id == ID)) return
            let data = await sendFiles("api/saveAva");
            if (data.value)
                this.AvatarSrc = data.value;
        },
        changeLike: async function (postId) {
            console.log(postId)
            let data = await api("changeLiked", { postId: postId });
            console.log(data)
            if (data.value) {
                let post = this.Posts.filter(post => post.id == postId)[0]
                post.isLiked = data.value.isliked;
                post.likesCount = data.value.likesCount
            }
        },
        changeDisLike: async function (postId) {
            let data = await api("changeDisLiked", { postId: postId });
            console.log(data)
            if (data.value) {
                let post = this.Posts.filter(post => post.id == postId)[0]
                post.isDisliked = data.value.isDisliked;
                post.disLikesCount = data.value.disLikesCount
            }
        },
        getImg(){

        }
    }
})
async function formChange() {
    data = {};
    name = $(this).attr("name")
    data[name] = $(this).val();
    data.Id = vm.Id;
    console.log(await api("updateUser",data));
}
let my;
let lastPost = 0;
async function getPosts() {
    let posts = await api("getPosts", { UserId: my.Id,Offset:lastPost });
    lastPost += posts.length;
    vm.Posts = [...vm.Posts,...posts ]
}
$(window).scroll(async function(){
    if($(window).scrollTop()+$(window).height()>=$(document).height()){
        let count=await getPosts();
    }
})
$("#app").hide()
$(document).ready(async function () {
    
    my = await api("getMy");
    my = JSON.parse(my);
    if ((ID!=my.Id)&&ID) {
        my = await api("getUser", { id: ID });
        my = JSON.parse(my);
        $(".Data input").attr("readonly", true)
        $(".Data textarea").attr("readonly", true)
        vm = Object.assign(vm, my);
        $("#app").show()
        vm.edit = 0;
        getPosts()
        return;
    } 
    if (!my.Id) location.href = "/Auth";
    vm = Object.assign(vm, my);
    getPosts()
    $(".Data input").on("input", formChange)
    $(".Data textarea").on("input", formChange)
    

    $("#app").show()
})
