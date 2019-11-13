$(document).ready(async function () {
    let sideBar = document.querySelector('#sidebarCategories');
    $.get('/Home/Categories').then(res => {
        Array.from(res).forEach(x => {
            $(sideBar)
                .append(`<li class="nav-item"><a class="nav-link" href="#"><i class="fas fa-${x.IconClass}"></i> ${x.Name} </a></li>`);
        });
    });
});