document.addEventListener('DOMContentLoaded', function () {
    const darkModeToggle = document.getElementById('darkModeToggle');

    darkModeToggle.addEventListener('change', function () {
        document.body.classList.toggle('dark-mode', darkModeToggle.checked);

        var r = document.querySelector(':root');

        if (darkModeToggle.checked) {
            r.style.setProperty('--primary-text-color', 'white');
            r.style.setProperty('--primary-background-color', 'black')
            r.style.setProperty('--secondary-background-color', '#222')
            r.style.setProperty('--third-background-color', '#130020')
        } else {
            r.style.setProperty('--primary-text-color', 'black');
            r.style.setProperty('--primary-background-color', '#f1f1d3')
            r.style.setProperty('--secondary-background-color', '#ffffff')
            r.style.setProperty('--third-background-color', '#ecffdf')
        }

    });
});
