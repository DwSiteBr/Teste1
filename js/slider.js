const slider = document.getElementById('slider');
const slidesEl = slider.querySelector('.slides');
const totalSlides = slidesEl.children.length;
const prevBtn = slider.querySelector('.prev');
const nextBtn = slider.querySelector('.next');

let index = 0;
let autoPlay = setInterval(nextSlide, 4000);

function showSlide(i){
  index = (i + totalSlides) % totalSlides;
  slidesEl.style.transform = `translateX(-${index * 100}%)`;
}
function nextSlide(){ showSlide(index + 1); }
function prevSlide(){ showSlide(index - 1); }

nextBtn.addEventListener('click', ()=>{ nextSlide(); resetAuto(); });
prevBtn.addEventListener('click', ()=>{ prevSlide(); resetAuto(); });

function resetAuto(){
  clearInterval(autoPlay);
  autoPlay = setInterval(nextSlide, 4000);
}

showSlide(0);