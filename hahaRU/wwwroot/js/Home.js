let vm = new Vue({
    el: "#app",
    data: {
        Posts: [],
        Users: {}
    }
})
let lastPost = 0;
async function load() {
    let posts = await api("getPosts", { Offset: lastPost, Count: 20 });
    lastPost += posts.length;
    for (Post of posts) {
        if (!vm.Users[Post.userId])
            vm.Users[Post.userId] = JSON.parse(await api("getUser", { id: Post.userId })); 
    }
    vm.Posts = posts;
}
load().then();