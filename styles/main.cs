body {
  margin: 0;
  padding: 0;
  overflow-x: hidden;
}

.main-container {
  display: flex;
  flex-direction: column;
  background-color: #dddada;
}

/*************************************************HOME HEADER**************************************************/
.home-header {
  background-image: url(../assets/image/offer-img.jpeg);
  width: 100vw;
  height: 100vh;
  background-repeat: no-repeat;
  background-size: cover;
  object-fit: cover;
  background-position: center;
}

.home-title {
  color: white;
  font-size: 80px;
  font-family: "Times New Roman";
  text-align: center;
  margin-top: 20vh;
  font-weight: bolder;
}

/*************************************************HOME BTN**************************************************/
/*
.home-btn{
  margin-left: 650px;
  margin-top: 170px;

}
.home-scroll-btn{
  border: 2px solid white;
  border-radius: 30px;
  height: 50px;
  width: 30px;
  background-color: transparent;
  -webkit-border-radius: 30px;
  -moz-border-radius: 30px;
  -ms-border-radius: 30px;
  -o-border-radius: 30px;
} 
.point{
  padding-top: 3px;
  color: white;
  height: 80px;
  font-weight: bold;
}  
*/
/*************************************************NAVIGATION**************************************************/
/*
.nav-link{
  text-decoration: none;
  color: black;
  font-size: 25px;
  font-family: $title-font-family;
  font-weight: 500;
  line-height: 4rem;
  border-radius: 25px;
  -webkit-border-radius: 25px;
  -moz-border-radius: 25px;
  -ms-border-radius: 25px;
  -o-border-radius: 25px;
  padding: 30px;
}
.nav-link:hover{
  background-color: $btn-color;
  transition-duration: 1.3s;
  text-decoration: none;
  color: black;
  border: none;
}   

.nav-item{
  width: fit-content;
  height: fit-content;
  margin-left: auto;
  margin-right: auto;

}
.nav-item:hover{
  padding-right: 30px;
  padding-left: 30px;
}*/
/*************************************************BOOKING FORM**************************************************/
.form-title {
  font-size: 70px;
  font-family: "Times New Roman";
  text-align: center;
  margin-top: 100px;
  margin-bottom: 20px;
}

.booking-form {
  background-color: white;
  height: 150px;
  width: 90vw;
  margin-left: auto;
  margin-right: auto;
  display: flex;
  flex-direction: row;
  margin-bottom: 100px;
  box-shadow: 1px 1px 8px rgba(0, 0, 0, 0.228);
}

.booking-form-box {
  display: flex;
  flex-direction: column;
}

.booking-label {
  margin-top: 30px;
  margin-left: 30px;
  color: black;
  font-weight: 500;
}

.booking-input {
  margin-left: 30px;
  color: #817f7f;
  border: 1px solid #cecbcb;
  border-radius: 5px;
  background-color: white;
  outline: none;
  height: 50px;
  width: 250px;
  -webkit-border-radius: 5px;
  -moz-border-radius: 5px;
  -ms-border-radius: 5px;
  -o-border-radius: 5px;
}

.booking-input-number {
  margin-left: 30px;
  color: #817f7f;
  border: 1px solid #cecbcb;
  border-radius: 5px;
  background-color: white;
  outline: none;
  height: 50px;
  width: 140px;
  -webkit-border-radius: 5px;
  -moz-border-radius: 5px;
  -ms-border-radius: 5px;
  -o-border-radius: 5px;
}

.booking-btn {
  border-radius: 25px;
  background-color: #ff7322;
  height: 50px;
  width: 260px;
  margin-top: 60px;
  margin-left: 30px;
  border: none;
  color: white;
  margin-bottom: 60px;
  transition: 1s;
  -webkit-transition: 1s;
  -moz-transition: 1s;
  -ms-transition: 1s;
  -o-transition: 1s;
}

.booking-btn:hover {
  opacity: 0.5;
}

/*************************************************WELCOME**************************************************/
.welcome-content {
  width: 100vw;
  height: 110vh;
  background-color: white;
  display: flex;
  flex-direction: row;
}

.welcome-box {
  width: 35vw;
  height: fit-content;
}

.welcome-to-casahotel {
  font-size: 70px;
  font-family: "Times New Roman";
  margin-top: 100px;
  margin-left: 60px;
  line-height: 4rem;
}

.welcome-paragraph {
  margin-left: 60px;
  margin-top: 25px;
  color: #555555;
}

.welcome-paragraph-2 {
  margin-left: 60px;
  margin-top: 25px;
  color: #807e7e;
}

.btn-box {
  display: flex;
  flex-direction: row;
}

.welcome-btn {
  border-radius: 25px;
  background-color: #ff7322;
  height: 50px;
  width: 160px;
  margin-left: 60px;
  margin-top: 25px;
  border: none;
  color: white;
  transition: 1s;
  -webkit-transition: 1s;
  -moz-transition: 1s;
  -ms-transition: 1s;
  -o-transition: 1s;
}

.welcome-btn:hover {
  opacity: 0.5;
}

.or {
  margin-top: 40px;
  margin-left: 25px;
  color: #807e7e;
}

.see-video {
  margin-left: 25px;
  margin-top: 40px;
  color: #ff7322;
  text-decoration: none;
}

.image-wrapper {
  width: fit-content;
  height: fit-content;
  display: flex;
  flex-direction: row;
  margin-left: 130px;
  margin-top: 70px;
}

.welcome-img-1 {
  width: 120px;
  height: 120px;
  border-radius: 120px;
  -webkit-border-radius: 120px;
  -moz-border-radius: 120px;
  -ms-border-radius: 120px;
  -o-border-radius: 120px;
  object-fit: cover;
  margin-top: 60px;
  margin-right: 30px;
}

.welcome-img-2 {
  width: 300px;
  height: 400px;
  object-fit: cover;
  margin-top: 50px;
}

.welcome-img-3 {
  width: 200px;
  height: 200px;
  border-radius: 200px;
  -webkit-border-radius: 200px;
  -moz-border-radius: 200px;
  -ms-border-radius: 200px;
  -o-border-radius: 200px;
  object-fit: cover;
  margin-top: 280px;
}

/*************************************************OFFERS**************************************************/
.offers {
  width: 100vw;
  height: fit-content;
  display: flex;
  flex-direction: column;
}

.offer-title {
  font-size: 70px;
  font-family: "Times New Roman";
  text-align: center;
  margin-top: 100px;
  margin-bottom: 10px;
}

.offer-paragraph {
  width: 60vw;
  margin-left: auto;
  margin-right: auto;
  margin-bottom: 60px;
  text-align: center;
  color: #555555;
}

.offer-main {
  width: 90vw;
  display: flex;
  flex-direction: row;
  margin-left: auto;
  margin-right: auto;
  background-color: white;
}

.offer-img-1 {
  width: 45vw;
  height: 630px;
  object-fit: cover;
}

.offer-image {
  height: fit-content;
}

.offer-price {
  width: 37vw;
  margin-left: auto;
  margin-right: auto;
}

.price-time {
  display: flex;
  flex-direction: row;
}

.price {
  color: #ff7322;
  font-size: 50px;
  margin-top: 60px;
}

.time {
  margin-left: 5px;
  margin-top: 100px;
  color: #807e7e;
}

.price-title {
  font-family: "Times New Roman";
  font-size: 35px;
}

.price-paragraph {
  color: #555555;
  line-height: 2rem;
  font-size: 16px;
}

.price-paragraph-2 {
  color: #807e7e;
  line-height: 1.7rem;
  font-size: 15px;
  margin-top: 20px;
}

.offer-booking-btn {
  border-radius: 25px;
  background-color: #ff7322;
  height: 50px;
  width: 160px;
  margin-top: 25px;
  border: none;
  color: white;
  margin-bottom: 60px;
  transition: 1s;
  -webkit-transition: 1s;
  -moz-transition: 1s;
  -ms-transition: 1s;
  -o-transition: 1s;
}

.offer-booking-btn:hover {
  opacity: 0.5;
}

.view-btn-box {
  margin-left: auto;
  margin-right: auto;
  height: 40vh;
}

.view-btn {
  border-radius: 27.5px;
  background-color: #ff7322;
  height: 55px;
  width: 230px;
  border: none;
  color: white;
  -webkit-border-radius: 27.5px;
  -moz-border-radius: 27.5px;
  -ms-border-radius: 27.5px;
  -o-border-radius: 27.5px;
  margin-top: 60px;
  transition: 1s;
  -webkit-transition: 1s;
  -moz-transition: 1s;
  -ms-transition: 1s;
  -o-transition: 1s;
}

.view-btn:hover {
  opacity: 0.5;
}

/*************************************************GALLERY**************************************************/
.carousel-content {
  height: 190vh;
  width: 100vw;
  display: flex;
  flex-direction: column;
  background-color: white;
}

.gallery-title {
  font-size: 70px;
  font-family: "Times New Roman";
  text-align: center;
  margin-top: 100px;
  margin-bottom: 10px;
}

.gallery-paragraph {
  width: 60vw;
  margin-left: auto;
  margin-right: auto;
  margin-bottom: 60px;
  text-align: center;
  color: #807e7e;
}

.testimonial-image {
  width: auto;
  height: 100vh;
  object-fit: cover;
  overflow-x: hidden;
  padding: 0 100px;
}

.view-more-photos {
  margin-left: auto;
  margin-right: auto;
  margin-top: 60px;
}

.view-more-photos-link {
  color: #ff7322;
  text-decoration: none;
}

/*************************************************TESTIMONIAL**************************************************/
.testimonial {
  background-color: #c79595;
  height: 160vh;
}

.testimonial-title {
  font-size: 70px;
  font-family: "Times New Roman";
  text-align: center;
  margin-bottom: 80px;
  margin-top: 100px;
}

.testimonial-comments {
  display: flex;
  flex-direction: row;
  width: 90vw;
}

.testimonial-img-p {
  width: 450px;
  display: flex;
  flex-direction: column;
  text-align: center;
  align-items: center;
  margin-left: 100px;
}

.testimonial-image-carousel {
  border-radius: 100px;
  -webkit-border-radius: 100px;
  -moz-border-radius: 100px;
  -ms-border-radius: 100px;
  -o-border-radius: 100px;
  width: 100px;
  height: 100px;
  object-fit: cover;
}

.testimonial-paragraph {
  line-height: 1.8rem;
  color: black;
}

.testimonial-nick {
  color: #555555;
  margin-bottom: 40px;
  margin-top: 40px;
}

.carousel-control-prev, .carousel-control-next {
  margin-left: -50px;
  margin-right: -50px;
}

/*************************************************EVENT**************************************************/
.event-title {
  font-size: 70px;
  font-family: "Times New Roman";
  text-align: center;
  margin-top: 100px;
  margin-bottom: 10px;
}

.event-paragraph {
  width: 60vw;
  margin-left: auto;
  margin-right: auto;
  margin-bottom: 60px;
  text-align: center;
  color: #807e7e;
}

.event-content {
  display: flex;
  flex-direction: row;
  width: 90vw;
  height: fit-content;
  justify-content: space-between;
  margin-left: auto;
  margin-right: auto;
}

.event-img-box {
  display: flex;
  flex-direction: column;
  background-color: white;
  width: 380px;
  box-shadow: 1px 1px 8px rgba(0, 0, 0, 0.228);
  margin-bottom: 170px;
}

.image-events {
  width: 380px;
  height: 270px;
  object-fit: cover;
}

.event-date {
  color: #555555;
  margin-top: 30px;
  margin-left: 25px;
  letter-spacing: 2px;
}

.event-paragraph-box {
  margin-left: 25px;
  margin-right: 25px;
  font-family: Gill Sans;
  font-size: 30px;
  font-weight: 540;
}

/*************************************************RESERVE**************************************************/
.reserve-content {
  background-color: white;
  height: fit-content;
  width: 100vw;
  display: flex;
  flex-direction: row;
}

.reserve-paragraph {
  font-family: Gill Sans;
  font-size: 30px;
  margin-left: 60px;
  margin-top: 80px;
  margin-bottom: 80px;
}

.reserve-btn {
  border-radius: 25px;
  background-color: #ff7322;
  height: 50px;
  width: 180px;
  border: none;
  color: white;
  margin-top: 120px;
  margin-left: 580px;
  transition: 1s;
  -webkit-transition: 1s;
  -moz-transition: 1s;
  -ms-transition: 1s;
  -o-transition: 1s;
}

.reserve-btn:hover {
  opacity: 0.5;
}

/*************************************************FOOTER**************************************************/
.footer {
  background-color: #222422;
  height: fit-content;
  width: 100vw;
}

.footer-content {
  display: flex;
  flex-direction: row;
  margin-top: 100px;
  margin-left: 20px;
  margin-right: 60px;
}

.footer-ul-1 {
  line-height: 2.5rem;
  margin-right: 140px;
}

.footer-ul-2 {
  line-height: 2.5rem;
  margin-right: 140px;
}

.footer-li {
  list-style: none;
}

.footer-link {
  text-decoration: none;
  color: #b3b9b3;
}

.footer-contact {
  display: flex;
  flex-direction: column;
  line-height: 2.5rem;
  margin-right: 50px;
  width: 300px;
}

.contact-name {
  color: white;
}

.address {
  width: 18px;
  margin-right: 12px;
  color: #7e7d7b;
}

.link {
  color: #666563;
}

.footer-paragraph {
  color: #7e7d7c;
  margin-bottom: 40px;
}

input {
  border-top: none;
  border-left: none;
  border-right: none;
  outline: none;
  width: 270px;
  background-color: #222422;
  color: white;
  height: 30px;
}

::-webkit-input-placeholder {
  color: #575553;
  font-family: "Trebuchet MS", "Lucida Sans Unicode", "Lucida Grande", "Lucida Sans", Arial, sans-serif;
  margin-bottom: 17px;
  padding-left: 5px;
}

.horyzontal-line {
  margin-left: 60px;
  margin-right: 60px;
  background-color: #575553;
  margin-top: 110px;
}

.footer-sentance {
  color: white;
  margin-left: 100px;
  color: #747070;
  margin-top: 60px;
  margin-bottom: 110px;
}

.colorlib {
  color: #a09e9c;
}

.footer-icon {
  width: 20px;
  margin-right: 20px;
}

.footer-icon-box {
  margin-left: 480px;
}

body {
  margin: 0;
  padding: 0;
  overflow-x: hidden;
}

.main-container {
  display: flex;
  flex-direction: column;
  background-color: #dddada;
}

.home-header {
  background-image: url(../assets/image/offer-img.jpeg);
  width: 100vw;
  height: 100vh;
  background-repeat: no-repeat;
  background-size: cover;
  object-fit: cover;
  background-position: center;
}

.home-title {
  color: white;
  font-size: 80px;
  font-family: "Times New Roman";
  text-align: center;
  margin-top: 20vh;
  font-weight: bolder;
}

/*
.home-btn{
  margin-left: 650px;
  margin-top: 170px;

}
.home-scroll-btn{
  border: 2px solid white;
  border-radius: 30px;
  height: 50px;
  width: 30px;
  background-color: transparent;
  -webkit-border-radius: 30px;
  -moz-border-radius: 30px;
  -ms-border-radius: 30px;
  -o-border-radius: 30px;
} 
.point{
  padding-top: 3px;
  color: white;
  height: 80px;
  font-weight: bold;
}  
*/
.reservation-booking-form {
  width: 100vw;
  height: fit-content;
}

.form-box-name {
  display: flex;
  flex-direction: column;
}

.form-box {
  display: flex;
  flex-direction: row;
}

.form-email {
  display: flex;
  flex-direction: column;
}

.form-t {
  display: flex;
  flex-direction: row;
}

.label-check {
  display: block;
}

.form-box-checkin {
  margin-left: 20px;
}

.testimonial {
  background-color: #c79595;
  height: 160vh;
}

.testimonial-title {
  font-size: 70px;
  font-family: "Times New Roman";
  text-align: center;
  margin-bottom: 80px;
  margin-top: 100px;
}

.testimonial-comments {
  display: flex;
  flex-direction: row;
  width: 90vw;
}

.testimonial-img-p {
  width: 450px;
  display: flex;
  flex-direction: column;
  text-align: center;
  align-items: center;
  margin-left: 100px;
}

.testimonial-image-carousel {
  border-radius: 100px;
  -webkit-border-radius: 100px;
  -moz-border-radius: 100px;
  -ms-border-radius: 100px;
  -o-border-radius: 100px;
  width: 100px;
  height: 100px;
  object-fit: cover;
}

.testimonial-paragraph {
  line-height: 1.8rem;
  color: black;
}

.testimonial-nick {
  color: #555555;
  margin-bottom: 40px;
  margin-top: 40px;
}

.carousel-control-prev, .carousel-control-next {
  margin-left: -50px;
  margin-right: -50px;
}

.reserve-content {
  background-color: white;
  height: fit-content;
  width: 100vw;
  display: flex;
  flex-direction: row;
}

.reserve-paragraph {
  font-family: Gill Sans;
  font-size: 30px;
  margin-left: 60px;
  margin-top: 80px;
  margin-bottom: 80px;
}

.reserve-btn {
  border-radius: 25px;
  background-color: #ff7322;
  height: 50px;
  width: 180px;
  border: none;
  color: white;
  margin-top: 120px;
  margin-left: 580px;
  transition: 1s;
  -webkit-transition: 1s;
  -moz-transition: 1s;
  -ms-transition: 1s;
  -o-transition: 1s;
}

.reserve-btn:hover {
  opacity: 0.5;
}

.footer {
  background-color: #222422;
  height: fit-content;
  width: 100vw;
}

.footer-content {
  display: flex;
  flex-direction: row;
  margin-top: 100px;
  margin-left: 20px;
  margin-right: 60px;
}

.footer-ul-1 {
  line-height: 2.5rem;
  margin-right: 140px;
}

.footer-ul-2 {
  line-height: 2.5rem;
  margin-right: 140px;
}

.footer-li {
  list-style: none;
}

.footer-link {
  text-decoration: none;
  color: #b3b9b3;
}

.footer-contact {
  display: flex;
  flex-direction: column;
  line-height: 2.5rem;
  margin-right: 50px;
  width: 300px;
}

.contact-name {
  color: white;
}

.address {
  width: 18px;
  margin-right: 12px;
  color: #7e7d7b;
}

.link {
  color: #666563;
}

.footer-paragraph {
  color: #7e7d7c;
  margin-bottom: 40px;
}

input {
  border-top: none;
  border-left: none;
  border-right: none;
  outline: none;
  width: 270px;
  background-color: #222422;
  color: white;
  height: 30px;
}

::-webkit-input-placeholder {
  color: #575553;
  font-family: "Trebuchet MS", "Lucida Sans Unicode", "Lucida Grande", "Lucida Sans", Arial, sans-serif;
  margin-bottom: 17px;
  padding-left: 5px;
}

.horyzontal-line {
  margin-left: 60px;
  margin-right: 60px;
  background-color: #575553;
  margin-top: 110px;
}

.footer-sentance {
  color: white;
  margin-left: 100px;
  color: #747070;
  margin-top: 60px;
  margin-bottom: 110px;
}

.colorlib {
  color: #a09e9c;
}

.footer-icon {
  width: 20px;
  margin-right: 20px;
}

.footer-icon-box {
  margin-left: 480px;
}

body {
  margin: 0;
  padding: 0;
  overflow-x: hidden;
}

.main-container {
  display: flex;
  flex-direction: column;
  background-color: #dddada;
}

.home-header {
  background-image: url(../assets/image/offer-img.jpeg);
  width: 100vw;
  height: 100vh;
  background-repeat: no-repeat;
  background-size: cover;
  object-fit: cover;
}

.home-title {
  color: white;
  font-size: 80px;
  font-family: "Times New Roman";
  text-align: center;
  margin-top: 20vh;
  font-weight: bolder;
}

/*    
.home-btn{
  margin-left: 650px;
  margin-top: 300px;

}
.home-scroll-btn{
  border: 2px solid white;
  border-radius: 30px;
  height: 50px;
  width: 30px;
  background-color: transparent;
  -webkit-border-radius: 30px;
  -moz-border-radius: 30px;
  -ms-border-radius: 30px;
  -o-border-radius: 30px;
} 
.point{
  padding-top: 3px;
  color: white;
  height: 80px;
  font-weight: bold;
}  
*/
.form-title {
  font-size: 70px;
  font-family: "Times New Roman";
  text-align: center;
  margin-top: 100px;
  margin-bottom: 20px;
}

.offer {
  margin-top: 100px;
}

.offer-main {
  width: 90vw;
  display: flex;
  flex-direction: row;
  margin-left: auto;
  margin-right: auto;
  background-color: white;
}

.offer-img-1 {
  width: 45vw;
  height: 630px;
  object-fit: cover;
}

.offer-image {
  height: fit-content;
}

.offer-price {
  width: 37vw;
  margin-left: auto;
  margin-right: auto;
}

.price-time {
  display: flex;
  flex-direction: row;
}

.price {
  color: #ff7322;
  font-size: 50px;
  margin-top: 60px;
}

.time {
  margin-left: 5px;
  margin-top: 100px;
  color: #807e7e;
}

.price-title {
  font-family: "Times New Roman";
  font-size: 35px;
}

.price-paragraph {
  color: #555555;
  line-height: 2rem;
  font-size: 16px;
}

.price-paragraph-2 {
  color: #807e7e;
  line-height: 1.7rem;
  font-size: 15px;
  margin-top: 20px;
}

.offer-booking-btn {
  border-radius: 25px;
  background-color: #ff7322;
  height: 50px;
  width: 160px;
  margin-top: 25px;
  border: none;
  color: white;
  margin-bottom: 60px;
  transition: 1s;
  -webkit-transition: 1s;
  -moz-transition: 1s;
  -ms-transition: 1s;
  -o-transition: 1s;
}

.offer-booking-btn:hover {
  opacity: 0.5;
}

.carousel-content {
  height: 190vh;
  width: 100vw;
  display: flex;
  flex-direction: column;
  background-color: white;
}

.gallery-title {
  font-size: 70px;
  font-family: "Times New Roman";
  text-align: center;
  margin-top: 100px;
  margin-bottom: 10px;
}

.gallery-paragraph {
  width: 60vw;
  margin-left: auto;
  margin-right: auto;
  margin-bottom: 60px;
  text-align: center;
  color: #807e7e;
}

.testimonial-image {
  width: auto;
  height: 100vh;
  object-fit: cover;
  overflow-x: hidden;
  padding: 0 100px;
}

.view-more-photos {
  margin-left: auto;
  margin-right: auto;
  margin-top: 60px;
}

.view-more-photos-link {
  color: #ff7322;
  text-decoration: none;
}

.testimonial {
  background-color: #c79595;
  height: 160vh;
}

.testimonial-title {
  font-size: 70px;
  font-family: "Times New Roman";
  text-align: center;
  margin-bottom: 80px;
  margin-top: 100px;
}

.testimonial-comments {
  display: flex;
  flex-direction: row;
  width: 90vw;
}

.testimonial-img-p {
  width: 450px;
  display: flex;
  flex-direction: column;
  text-align: center;
  align-items: center;
  margin-left: 100px;
}

.testimonial-image-carousel {
  border-radius: 100px;
  -webkit-border-radius: 100px;
  -moz-border-radius: 100px;
  -ms-border-radius: 100px;
  -o-border-radius: 100px;
  width: 100px;
  height: 100px;
  object-fit: cover;
}

.testimonial-paragraph {
  line-height: 1.8rem;
  color: black;
}

.testimonial-nick {
  color: #555555;
  margin-bottom: 40px;
  margin-top: 40px;
}

.carousel-control-prev, .carousel-control-next {
  margin-left: -50px;
  margin-right: -50px;
}

.reserve-content {
  background-color: white;
  height: fit-content;
  width: 100vw;
  display: flex;
  flex-direction: row;
}

.reserve-paragraph {
  font-family: Gill Sans;
  font-size: 30px;
  margin-left: 60px;
  margin-top: 80px;
  margin-bottom: 80px;
}

.reserve-btn {
  border-radius: 25px;
  background-color: #ff7322;
  height: 50px;
  width: 180px;
  border: none;
  color: white;
  margin-top: 120px;
  margin-left: 580px;
  transition: 1s;
  -webkit-transition: 1s;
  -moz-transition: 1s;
  -ms-transition: 1s;
  -o-transition: 1s;
}

.reserve-btn:hover {
  opacity: 0.5;
}

.footer {
  background-color: #222422;
  height: fit-content;
  width: 100vw;
}

.footer-content {
  display: flex;
  flex-direction: row;
  margin-top: 100px;
  margin-left: 20px;
  margin-right: 60px;
}

.footer-ul-1 {
  line-height: 2.5rem;
  margin-right: 140px;
}

.footer-ul-2 {
  line-height: 2.5rem;
  margin-right: 140px;
}

.footer-li {
  list-style: none;
}

.footer-link {
  text-decoration: none;
  color: #b3b9b3;
}

.footer-contact {
  display: flex;
  flex-direction: column;
  line-height: 2.5rem;
  margin-right: 50px;
  width: 300px;
}

.contact-name {
  color: white;
}

.address {
  width: 18px;
  margin-right: 12px;
  color: #7e7d7b;
}

.link {
  color: #666563;
}

.footer-paragraph {
  color: #7e7d7c;
  margin-bottom: 40px;
}

input {
  border-top: none;
  border-left: none;
  border-right: none;
  outline: none;
  width: 270px;
  background-color: #222422;
  color: white;
  height: 30px;
}

::-webkit-input-placeholder {
  color: #575553;
  font-family: "Trebuchet MS", "Lucida Sans Unicode", "Lucida Grande", "Lucida Sans", Arial, sans-serif;
  margin-bottom: 17px;
  padding-left: 5px;
}

.horyzontal-line {
  margin-left: 60px;
  margin-right: 60px;
  background-color: #575553;
  margin-top: 110px;
}

.footer-sentance {
  color: white;
  margin-left: 100px;
  color: #747070;
  margin-top: 60px;
  margin-bottom: 110px;
}

.colorlib {
  color: #a09e9c;
}

.footer-icon {
  width: 20px;
  margin-right: 20px;
}

.footer-icon-box {
  margin-left: 480px;
}

/*# sourceMappingURL=main.cs.map */
