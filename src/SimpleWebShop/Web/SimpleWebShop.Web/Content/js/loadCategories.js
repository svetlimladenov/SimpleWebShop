$(document).ready(async function () {
    let categoriesNav = $('#main-menu-nav');
    $.get('/Home/Categories').then(res => {
        Array.from(res).forEach(x => {
            let parentCategory = 
                $(`<div class="btn-group dropdown-submenu">
                        <button type="button" class="btn text-left dropdown-toggle waves-effect waves-light" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
                            <i class="fas fa-${x.IconClass}"></i> ${x.Name}
                        </button>
                </div>`);
            let subMenu = $(`<div class="dropdown-menu"><h4 class="child-category-header">${x.Name}</h4></div>`);
            for (var category of x.ChildCategories) {
                subMenu.append(`<a class="dropdown-item" href="/${category.NameForLink}">${category.Name}</a>`)
            }
            parentCategory.append(subMenu);
            categoriesNav.append(parentCategory);
        });

        $(function () {
            $("div.dropdown-menu [data-toggle='dropdown']").on("click", function (event) {
                event.preventDefault();
                event.stopPropagation();

                $(this).siblings().toggleClass("show");


                if (!$(this).next().hasClass('show')) {
                    $(this).parents('.dropdown-menu').first().find('.show').removeClass("show");
                }
                $(this).parents('li.nav-item.dropdown.show').on('hidden.bs.dropdown', function (e) {
                    $('.dropdown-submenu .show').removeClass("show");
                });

            });
        });
    });
});