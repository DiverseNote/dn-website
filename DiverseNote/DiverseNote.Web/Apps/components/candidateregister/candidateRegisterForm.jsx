"use strict";

var React = require('react');
var TextBox = require('../Common/InputControls/textbox.jsx');
var MultiSelect = require('../Common/InputControls/multiselect.jsx');
var DropDownBox = require('../Common/InputControls/dropDownBox.jsx');
var Button = require('../Common/InputControls/button.jsx');
var CandidateRegisterForm = React.createClass({
    render: function () {

        var experienceItems = [{ "text": "", "value": "" }, { "text": "0-2", "value": "0" }, { "text": "2-5", "value": "2" }, { "text": "6-10", "value": "6" }, { "text": "10+", "value": "10" }];
        var ethnicityItems = [{ "text": "", "value": "" }, { "text": "African American", "value": "AA" }, { "text": "Asian", "value": "A" }, { "text": "Caucasian", "value": "C" }, { "text": "Hispanic", "value": "H" }, { "text": "Native American", "value": "NA" }, { "text": "Pacific Islander", "value": "PI" }, { "text": "Other", "value": "O" }];
        var yesNoItems = [{ "text": "", "value": "" }, { "text": "Yes", "value": "Y" }, { "text": "No", "value": "N" }];
        var genderItems = [{ "text": "", "value": "" }, { "text": "Male", "value": "M" }, { "text": "Female", "value": "F" }];
        var jobTypeItems = [{ "text": "Internship", "value": "I" }, { "text": "Contract", "value": "C" }, { "text": "Full Time", "value": "F" }];

        return (
            <form>                
                <TextBox id="locationInput" label="Location" inputType="text" />
                <MultiSelect id="jobTypeInput" label="Job Type" inputType="checkbox" items={jobTypeItems} />                
                <DropDownBox id="experienceInput" label="Experience" items={experienceItems} />
                
            <h3>Diversity Factors</h3>
                <DropDownBox id="genderInput" label="Gender" inputType="checkbox" items={genderItems} />
                <DropDownBox id="ethnicityInput" label="Ethnicity" inputType="checkbox" items={ethnicityItems} />
                <DropDownBox id="disabledInput" label="Disabled?" inputType="checkbox" items={yesNoItems} />
                <DropDownBox id="veteranInput" label="US Military Veteran?" inputType="checkbox" items={yesNoItems} />
                <DropDownBox id="lgbtqInput" label="A Member of the LGBTQ Community" inputType="checkbox" items={yesNoItems} />
                <Button id="submitCandidateRegInput" label="Submit" route="#/Candidate" />
            </form>
            )
    }
});

module.exports = CandidateRegisterForm;