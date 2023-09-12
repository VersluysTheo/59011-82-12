var ampoule = document.querySelector("img");
ampoule.addEventListener('click', function() {
    ampoule.style.rotate = '180deg';
    ampoule.style.transition = 'all 4s ease-in';
    setTimeout(function() {
        ampoule.style.rotate = '0deg';
        ampoule.style.transition = 'all 4s ease-in';
    }, 6000);
});
