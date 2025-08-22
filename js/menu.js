const drawer = document.getElementById('menuDrawer');
const openBtn = document.getElementById('openMenu');

function closeDrawer(){ drawer.classList.remove('active'); }
function openDrawer(){ drawer.classList.add('active'); }

openBtn.addEventListener('click', openDrawer);
drawer.addEventListener('click', (e)=>{
  if(e.target.matches('[data-close]') || e.target === drawer.querySelector('.backdrop')) {
    closeDrawer();
  }
});