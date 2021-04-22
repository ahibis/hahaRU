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
        DisLikes:0,
        Posts: [],
        edit:1,
        AvatarSrc:"/img/logo.png"
    }
})
async function formChange() {
    data = {};
    name = $(this).attr("name")
    data[name] = $(this).val();
    data.Id = vm.Id;
    console.log(await api("updateUser",data));
}
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
        return;
    } 
    if (!my.Id) location.href = "/Auth";
    vm = Object.assign(vm, my);
    
    $(".Data input").on("input", formChange)
    $(".Data textarea").on("input", formChange)
    

    $("#app").show()
})
