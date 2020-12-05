
* { 
  margin: 0;
  padding: 0;
}

html {
  font-size: 100%;
  
}

body{
  max-width:1200px;
    margin: auto;
    font-family: "Raleway", sans-serif;
    font-size:0.8rem;
}

main {
  padding:0 5vh 0 5vh;
}

.header1 {
  display:grid;
  grid-template-columns: auto 1fr auto auto;
  grid-template-areas: "logo . nav inscription";
  padding: 4rem 2rem 0 2rem;
}

.logo {
  width: 100px;
  grid-area:logo;
  padding-bottom:40px;
}

a {
  text-decoration: none;
  color: black;
}

.menu{
  grid-area:nav;
  font-size:0.9rem;
}

.hebergements {
  padding: 35px; 
  color: #0065FC;
}

@media screen and (min-width: 768px){

  .hebergements {
    border-top: 3px solid #0065FC;
  }
}

.activites {
  padding: 0 35px;
}

.activites:hover {
  padding-top: 35px; 
  color: #0065FC;
  border-top: 3px solid #0065FC;
}

.inscription {
  grid-area:inscription;
  color: #0065FC;
  font-weight: bold;
  padding: 0 35px;
}

header {
  margin: 0 0 0 1rem;
}

#icon {
  padding: 15px 12px 18px 18px;
  background-color:  #F2F2F2;
  width:12px;
  height:10px;
  border-radius: 15px 0 0 15px;
  font-size:16px; 
}

.search_box{
    border-right: none;
    border-left: none;
    border-top: 1px solid #E9E9E9;
    border-bottom: 1px solid #E9E9E9;
    width: 180px;
    padding-left: 20px;
    font-weight: bold;
    color: black;
    font-size: 0.9rem;
}

input::placeholder {
  color: black;
}

.button_rechercher, .button_icon { 
  background: #0065FC;
  height: 43px;
  width: 110px;
  border-radius: 0 15px 15px 0; 
  color: white;
  border: none;
  font-size:14px;
}

.button_icon {
  display: none;
}

.search{
  display: inline-flex;
}

h1 {
  font-size: 1.4em;
  padding-bottom: 0.2em;
}

.sous_h1{
  font-weight: normal;
  font-size: 1.1em;
  padding-bottom: 1em;
}

.filter_category {
  display:inline-flex;
  align-items: center;
  border: 2px solid #DEDEDE;
  border-radius: 30px;
  margin-right: 22px;
  height:37px;
  cursor: pointer;
}

.search_filters {
  display:inline-flex;
  margin-top:30px;
}

.filter_icon{
  background-color: #DEEBFF;
  display: flex;
  border-radius: 100%;
  height:40px;
  width:40px;
  align-items: center;
  justify-content: center;
  font-size: 1.2em;
  color:  #0065FC; 
  margin-left:-5px;
}

.filter_title {
  margin-right: 15px;
  margin-left:10px;
  font-size: 0.9rem;
  font-weight:bold;
}

.filter_title_Filtre {
  font-weight:bold;
  margin-top: 13px;
  margin-right:30px;
  font-size: 0.9rem;
}

.filter_category:hover{
  color:white;
  border: 2px solid  #0065FC;
  background-color: #0065FC;
}

.blue {
  color: #0065FC;
}

.grey {
  color: #DEDEDE;
}




.result_info{
  display: flex; 
  align-items: center;
  margin-top:35px;

}

.info_icon{
  color: #0065FC;
  height: 1.3rem;
  width: 1.3rem;
  border-radius: 100%;
  display: flex;
  align-items: center;
  justify-content: center;
  border: 1px solid  #DEDEDE;
  margin-right: 0.6rem;
}


.all_hostings{
  display: grid;
  column-gap: 2.2em;
  grid-template-columns: 2fr 1fr;

}

.hosting{
  display: grid;
  grid-template-columns: repeat(3, 1fr);
  border-radius: 1em;
  column-gap: 1.5rem;
  row-gap: 1.5rem;
  background-color: #F2F2F2;
  margin: 2rem 0;
  padding:2.2rem;
}

.hosting_title {
  grid-column: 1/ span 3;
}

.hosting_card{
  border-radius: 1.25rem;
  box-shadow: 0 0px 15px #CECECE;
  padding: 0.3rem;
  background-color: white;
  font-size: 0.7rem;
  width: 200px;
}
  
.hosting_card:hover {
  background-color: #DEEBFF;
}

.hosting_card_img{
  border-radius: 1rem 1rem 0 0;
  object-fit: cover;
  width: 100%;
  height: 100px;
}

.hosting_name{
  margin:0.4rem;
  margin-left:0.7rem;
}

.hosting_night_price{
  margin: 0 .7rem;
}

.hosting_card_stars{
  margin-top: 0.4rem;
  margin-left:0.7rem;
  font-size:0.6rem;
}


.hosting_show_more{
  font-weight: bold;
}




.popular_hosting{
  display: grid;
  row-gap: 1.5rem;
  background-color: #F2F2F2;
  padding: 2.2rem;
  grid-template-columns: 1fr;
  margin: 2rem 0;
  border-radius: 1em;
}

.popular_hosting_title {
  display: flex;
  justify-content: space-between;
}

.popular_hosting_card {
  display:flex;
  border-radius: 1.25rem;
  box-shadow: 0 0px 15px #CECECE;
  padding: 0.3rem;
  background-color: white;
  font-size: 0.7rem;
}

.popular_hosting_card:hover {
  background-color: #DEEBFF;
  
}

.popular_hosting_card_img{
  object-fit: cover;
  width: 110px;
  height:115px;
  border-radius: 1rem 0 0 1rem;
}

.description {
  margin-left:0.6em;
}


.description .hosting_card_stars{
  margin-top: 40px;
}




.activities{
  margin: 2rem 0;
}

.activity_title {
  margin-bottom: 40px;
}

.all_activities {
  display: grid;
  grid-template-columns: repeat(4,1fr);
  grid-template-rows: 160px 30px 40px 130px;
  column-gap:2rem;
  grid-template-areas:"Vieux-Port Fort-de-Promegues Parc-National-des-Calanques Notre-Dame-de-la-Garde"
                      "Vieux-Port Fort-de-Promegues Parc-National-des-Calanques ."
                      "Vieux-Port . Parc-National-des-Calanques Parc-Longchamp"
                      "Vieux-Port Iles-du-Frioul Parc-National-des-Calanques Parc-Longchamp";
}

#activity_card1 {
  grid-area: Vieux-Port;
}

#activity_card2 {
  grid-area: Fort-de-Promegues;
}

#activity_card3 {
  grid-area: Parc-National-des-Calanques;
}

#activity_card4 {
  grid-area:Notre-Dame-de-la-Garde;
}

#activity_card5 {
  grid-area:Iles-du-Frioul;
}

#activity_card6 {
  grid-area:Parc-Longchamp;
}

.activity_card{
  box-shadow: 0 0px 10px #CECECE;
  border-radius: 1rem;
  font-size:0.8rem;
  display: flex;
  flex-direction: column;
}

.activity_card:hover {
  background-color: #DEEBFF;
}

.activity_card_img {
  object-fit: cover;
  width:100%;
  height: 100%;
  border-radius: 1rem 1rem 0 0;
  position: absolute;
}

.activity_img {
  position: relative;
  flex:1;
}

.activity_card_title {
  padding:0.8rem;
}




.all_footer {
  display: flex;
  background-color: #F2F2F2;
  padding: 5vh;
  margin-top:4rem;
}

.footer {
  width: 35%;
}

.footer_title {
  font-weight: bold;
  padding-bottom: 10px;
}

.footer_link {
  margin-top:10px;
}