$(document).ready(async function () {
    let buttons = document.querySelectorAll('.delete-btn');
    buttons.forEach(x => x.addEventListener('click',
        (e) => {
            let btn = $(x);
            let id = btn.data('id');
            let name = x.dataset.categoryName;
            let tableRow = btn.parent().parent();
            if (confirm(`Are you sure you want to delete ${name} category`)) {
                $.post('/Administration/CategoriesAdministration/Delete', { id: id }).then(res => {
                    console.log(res);
                    tableRow.remove();
                }).catch(err => {
                    console.log(err);
                });
            }
        }));
});