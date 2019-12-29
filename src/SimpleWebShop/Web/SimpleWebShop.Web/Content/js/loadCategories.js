$(document).ready(async function () {
    //let sideBar = $('#sidebarCategories');
    //$.get('/Home/Categories').then(res => {
    //    Array.from(res).forEach(x => {
    //        sideBar.append(`<li class="nav-item"><a class="nav-link" href="/${x.NameForLink}"><i class="fas fa-${x.IconClass}"></i> ${x.Name} </a></li>`);
    //    });
    //});


    let menu = document.querySelectorAll('.main-menu ul li');
    let dropDown = $('.drop-down');
    let dropDownTitle = $('.drop-down-title');

    menu.forEach((i) => {
        i.addEventListener('mouseover', (e) => {
            e.preventDefault();
            let $i = $(i);
            let a = $i.children(":first");
            dropDownTitle.text(a.text());
            dropDown.css('display', 'block');
            //TODO: Add sub menus with ajax
        });
    });
    menu.forEach((i) => {
        i.addEventListener('mouseout', (e) => {
            e.preventDefault();
            dropDown.css('display', 'none');
        });
    });
});