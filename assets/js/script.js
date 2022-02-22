
//back-to-home-link
var upper = document.getElementById("upper");
function myUpperFunction() {
  
  if (window.pageYOffset >= 80) {
    upper.classList.remove("d-none");
    upper.classList.add("d-flex");
  } else {
    upper.classList.add("d-none");
    upper.classList.remove("d-flex");
  }
}


const sections = document.querySelectorAll("section");
const navLi = document.querySelectorAll(".nav2Right  ul li .nav-link");

function activeLink() {
  var current = "";

  sections.forEach((section) => {
    const sectionTop = section.offsetTop;
    
    if (pageYOffset >= sectionTop-60) {
      current = section.getAttribute("id");
     }
  });
  let currentLinkActive=document.querySelector("."+current);
  console.log(currentLinkActive);

  navLi.forEach((link) => {

    link.classList.remove("active-color");
    currentLinkActive.classList.add("active-color");
    
  });
};