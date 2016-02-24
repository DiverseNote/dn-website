"use strict";
var React = require('react');
var CandidateList = require('./candidateList.jsx');
var SearchCriteria = require('./searchCriteria.jsx');
var FormLayout = require('../Common/Layouts/formLayout.jsx');
var fakeCandidates =
[
{
    "_id": "56ad264631cb53dba6e32c4a",
    "picture": "http://placehold.it/32x32",
    "name": "Hanson Everett",
    "title": "Nurse",
    "skills": "cupidatat qui veniam",
    "city": "Crown",
    "state": "Guam",
    "veteranStatus": "No",
    "gender": "male",
    "ethnicity": "African American",
    "salary": "$74,355"
},
{
    "_id": "56ad2646f91628c5803dc369",
    "picture": "http://placehold.it/32x32",
    "name": "Geraldine Carey",
    "title": "Software Developer",
    "skills": "nulla laboris veniam",
    "city": "Topanga",
    "state": "Alabama",
    "veteranStatus": "No",
    "gender": "female",
    "ethnicity": "Asian",
    "salary": "$135,648"
},
{
    "_id": "56ad2646a4113a622ae80221",
    "picture": "http://placehold.it/32x32",
    "name": "Raymond Hunt",
    "title": "Nurse",
    "skills": "reprehenderit fugiat cillum",
    "city": "Tivoli",
    "state": "Federated States Of Micronesia",
    "veteranStatus": "No",
    "gender": "male",
    "ethnicity": "African American",
    "salary": "$50,190"
},
{
    "_id": "56ad26466b640df0b69cd1dc",
    "picture": "http://placehold.it/32x32",
    "name": "Silvia Mack",
    "title": "Nurse",
    "skills": "eiusmod anim cillum",
    "city": "Belfair",
    "state": "Oregon",
    "veteranStatus": "No",
    "gender": "female",
    "ethnicity": "Pacific Islander",
    "salary": "$116,009"
},
{
    "_id": "56ad26467d866444d83f3568",
    "picture": "http://placehold.it/32x32",
    "name": "Karina Yang",
    "title": "Engineer",
    "skills": "fugiat in consequat",
    "city": "Terlingua",
    "state": "Maryland",
    "veteranStatus": "No",
    "gender": "female",
    "ethnicity": "Native American",
    "salary": "$81,459"
},
{
    "_id": "56ad26466b41b7f1d2c87653",
    "picture": "http://placehold.it/32x32",
    "name": "Brooks Franks",
    "title": "Software Developer",
    "skills": "incididunt commodo duis",
    "city": "Edenburg",
    "state": "Pennsylvania",
    "veteranStatus": "No",
    "gender": "male",
    "ethnicity": "Hispanic",
    "salary": "$49,028"
},
{
    "_id": "56ad2646d31666d3dbf44597",
    "picture": "http://placehold.it/32x32",
    "name": "Stacie Tanner",
    "title": "Nurse",
    "skills": "nulla qui mollit",
    "city": "Smeltertown",
    "state": "American Samoa",
    "veteranStatus": "No",
    "gender": "female",
    "ethnicity": "African American",
    "salary": "$149,998"
},
{
    "_id": "56ad264690ba041282bf8189",
    "picture": "http://placehold.it/32x32",
    "name": "Josefa Hart",
    "title": "Software Developer",
    "skills": "laborum dolore aliquip",
    "city": "Maxville",
    "state": "Virginia",
    "veteranStatus": "No",
    "gender": "female",
    "ethnicity": "Asian",
    "salary": "$91,264"
},
{
    "_id": "56ad2646cbf86115ea3b6f43",
    "picture": "http://placehold.it/32x32",
    "name": "Rodriquez Cantu",
    "title": "Software Developer",
    "skills": "ullamco laborum do",
    "city": "Felt",
    "state": "Delaware",
    "veteranStatus": "No",
    "gender": "male",
    "ethnicity": "African American",
    "salary": "$47,431"
},
{
    "_id": "56ad2646159b046bb468b86f",
    "picture": "http://placehold.it/32x32",
    "name": "Rojas Holland",
    "title": "Designer",
    "skills": "officia aliquip enim",
    "city": "Mahtowa",
    "state": "North Carolina",
    "veteranStatus": "No",
    "gender": "male",
    "ethnicity": "Pacific Islander",
    "salary": "$89,904"
},
{
    "_id": "56ad2646927606bab0f706e5",
    "picture": "http://placehold.it/32x32",
    "name": "Glenna Dorsey",
    "title": "Designer",
    "skills": "laborum Lorem aliquip",
    "city": "Efland",
    "state": "South Dakota",
    "veteranStatus": "No",
    "gender": "female",
    "ethnicity": "Asian",
    "salary": "$81,637"
},
{
    "_id": "56ad2646b3b42713148100aa",
    "picture": "http://placehold.it/32x32",
    "name": "Kirk Cline",
    "title": "Designer",
    "skills": "cillum ea qui",
    "city": "Fannett",
    "state": "Ohio",
    "veteranStatus": "No",
    "gender": "male",
    "ethnicity": "Asian",
    "salary": "$85,760"
},
{
    "_id": "56ad26466bc33837ac45e3f1",
    "picture": "http://placehold.it/32x32",
    "name": "Rosalie Guthrie",
    "title": "Engineer",
    "skills": "veniam ipsum duis",
    "city": "Sims",
    "state": "Nevada",
    "veteranStatus": "No",
    "gender": "female",
    "ethnicity": "Native American",
    "salary": "$146,433"
},
{
    "_id": "56ad26462bf83581e2f49028",
    "picture": "http://placehold.it/32x32",
    "name": "Louella Estrada",
    "title": "Nurse",
    "skills": "tempor laboris aliquip",
    "city": "Groveville",
    "state": "Florida",
    "veteranStatus": "No",
    "gender": "female",
    "ethnicity": "Asian",
    "salary": "$85,652"
},
{
    "_id": "56ad2646c1ffa22bf014f74c",
    "picture": "http://placehold.it/32x32",
    "name": "Teresa Garcia",
    "title": "Software Developer",
    "skills": "elit consectetur non",
    "city": "Gibsonia",
    "state": "Virgin Islands",
    "veteranStatus": "No",
    "gender": "female",
    "ethnicity": "Asian",
    "salary": "$108,959"
},
{
    "_id": "56ad2646178cd094b6a3a30e",
    "picture": "http://placehold.it/32x32",
    "name": "Sharlene Young",
    "title": "Software Developer",
    "skills": "ad ex dolor",
    "city": "Kansas",
    "state": "Colorado",
    "veteranStatus": "No",
    "gender": "female",
    "ethnicity": "African American",
    "salary": "$109,225"
},
{
    "_id": "56ad26467cdc71b6f1ca2d95",
    "picture": "http://placehold.it/32x32",
    "name": "Taylor Kane",
    "title": "Designer",
    "skills": "dolore pariatur dolor",
    "city": "Irwin",
    "state": "Massachusetts",
    "veteranStatus": "No",
    "gender": "female",
    "ethnicity": "Pacific Islander",
    "salary": "$43,282"
},
{
    "_id": "56ad2646f13a9b3b48d8b2a4",
    "picture": "http://placehold.it/32x32",
    "name": "Herman Mays",
    "title": "Engineer",
    "skills": "enim nostrud sunt",
    "city": "Elliott",
    "state": "South Carolina",
    "veteranStatus": "No",
    "gender": "male",
    "ethnicity": "Caucasion",
    "salary": "$104,194"
},
{
    "_id": "56ad2646d2a313aa1cd64da7",
    "picture": "http://placehold.it/32x32",
    "name": "Copeland Kramer",
    "title": "Engineer",
    "skills": "fugiat ullamco commodo",
    "city": "Sanborn",
    "state": "Northern Mariana Islands",
    "veteranStatus": "No",
    "gender": "male",
    "ethnicity": "Caucasion",
    "salary": "$133,449"
},
{
    "_id": "56ad2646d7175f1c899973a7",
    "picture": "http://placehold.it/32x32",
    "name": "Clarke Alvarado",
    "title": "Nurse",
    "skills": "in voluptate incididunt",
    "city": "Snelling",
    "state": "Minnesota",
    "veteranStatus": "No",
    "gender": "male",
    "ethnicity": "Pacific Islander",
    "salary": "$86,660"
},
{
    "_id": "56ad26461d00e860c47abb1b",
    "picture": "http://placehold.it/32x32",
    "name": "Valarie Moss",
    "title": "Nurse",
    "skills": "minim commodo officia",
    "city": "Ventress",
    "state": "Tennessee",
    "veteranStatus": "No",
    "gender": "female",
    "ethnicity": "African American",
    "salary": "$110,943"
},
{
    "_id": "56ad264631faab5490bd1a1a",
    "picture": "http://placehold.it/32x32",
    "name": "Vazquez Snyder",
    "title": "Designer",
    "skills": "laborum ex et",
    "city": "Caledonia",
    "state": "Utah",
    "veteranStatus": "No",
    "gender": "male",
    "ethnicity": "Asian",
    "salary": "$99,734"
},
{
    "_id": "56ad26460bb74046a55df491",
    "picture": "http://placehold.it/32x32",
    "name": "Yvonne Whitfield",
    "title": "Nurse",
    "skills": "proident ipsum dolor",
    "city": "Charco",
    "state": "Michigan",
    "veteranStatus": "No",
    "gender": "female",
    "ethnicity": "Caucasion",
    "salary": "$128,309"
},
{
    "_id": "56ad2646b7b8a736840f094d",
    "picture": "http://placehold.it/32x32",
    "name": "English Foley",
    "title": "Engineer",
    "skills": "nulla ea dolor",
    "city": "Matthews",
    "state": "Kansas",
    "veteranStatus": "No",
    "gender": "male",
    "ethnicity": "African American",
    "salary": "$51,091"
},
{
    "_id": "56ad2646d75ab91a90da0ad1",
    "picture": "http://placehold.it/32x32",
    "name": "Haynes Dickson",
    "title": "Nurse",
    "skills": "ea ullamco Lorem",
    "city": "Fidelis",
    "state": "California",
    "veteranStatus": "No",
    "gender": "male",
    "ethnicity": "Native American",
    "salary": "$148,154"
}
];

var Candidates = React.createClass({
       
    render: function () {
        var candidates = (
           <div className="container">                
                   <div className="row">
                       <div className="col-xs-12 col-sm-4 col-md-4"><SearchCriteria /></div>
                       <div className="col-xs-12 col-sm-8 col-md-8"><CandidateList candidates={fakeCandidates} /></div>
                   </div>
           </div>
            );
        return (
            <FormLayout content={candidates} pageTitle="Recruiting" />
            );
    }
});

module.exports = Candidates;