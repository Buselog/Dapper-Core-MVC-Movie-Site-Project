document.addEventListener('DOMContentLoaded', () => {
    const animItems = document.querySelectorAll('.slide-in-left, .slide-in-right, .dashboard-fade-in');

    function animOnScroll() {
        animItems.forEach(item => {
            const rect = item.getBoundingClientRect();
            if (rect.top < window.innerHeight * 0.85) {
                item.style.animationPlayState = 'running';
            }
        });
    }

    animItems.forEach(i => i.style.animationPlayState = 'paused');
    animOnScroll();

    window.addEventListener('scroll', animOnScroll);
});


//<script>
//  document.addEventListener('DOMContentLoaded', function() {
//    const element = document.querySelector('.fade-slide-in');

//    function checkVisibility() {
//      const rect = element.getBoundingClientRect();
//      const windowHeight = window.innerHeight || document.documentElement.clientHeight;

//      if (rect.top <= windowHeight - 100) {  // 100px farkla görünür olsun
//        element.classList.add('visible');
//      }
//    }

//    // İlk kontrol
//    checkVisibility();

//    // Scroll eventinde kontrol et
//    window.addEventListener('scroll', checkVisibility);
//  });
//</script>
