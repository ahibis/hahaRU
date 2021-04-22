//пост запрос через Ajax с объектом данных
function post(Url, data = {}) {
    return new Promise((resolve, reject) => {
        $.post('/' + Url, data, (Data) => {
            resolve(Data);
        });
    })
}
//get запрос через Ajax с объектом данных
function get(Url, data = {}) {
    return new Promise((resolve, reject) => {
        $.get('/' + Url, data, (Data) => {
            resolve(Data);
        });
    })
}
//запрос через Ajax с объектом данных по адресу api/method
function api(method, data = {}) {
    return new Promise((resolve, reject) => {
        $.post('/api/' + method, data, (Data) => {
            resolve(Data);
        });
    })
}
function registration() {
    let form = {};
    $("#auth input").each(function () {
        let el = $(this);
        let name = el.attr("name");
        if (name) {form[name]=el.val()}
    })
    post("Registration/Registration", form).then(r => {
        $("#message").text(r)
        if(r=="ok") location.href="/"
    })
}
function login() {
    let form = {};
    $("#auth input").each(function () {
        let el = $(this);
        let name = el.attr("name");
        if (name) { form[name] = el.val() }
    })
    post("Auth/Login", form).then(r => {
        $("#message").text(r)
        if (r == "ok") location.href = "/"
    })
}
my = {};
$(document).ready(async function () {
    my = await api("getMy");
    my = JSON.parse(my);
    if (!my.Login) $("#userLink").attr("href", "/Auth");  
    my.Login = (my.Login || "авторизоваться");
    $("#userName").text(my.Login);
    my.AvatarSrc = my.AvatarSrc || "/img/logo.png";
    $("#userImg").attr("src", my.AvatarSrc);
})