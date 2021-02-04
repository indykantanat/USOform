
function previewImage(input) {
    console.log(input.dataset.thumbnail);
    var preview = document.getElementById(input.dataset.thumbnail);
    if (input.files && input.files[0]) {
        var reader = new FileReader();
        reader.onload = function (e) {
            preview.setAttribute('src', e.target.result);
        }
        reader.readAsDataURL(input.files[0]);
    } else {
        preview.setAttribute('src', 'placeholder.png');
    }
}
