"use strict";

var React = require('react');
var TextBox = require('../Common/InputControls/textbox.jsx');
var MultiSelect = require('../Common/InputControls/multiselect.jsx');
var Button = require('../common/InputControls/button.jsx');

var SearchCriteria = React.createClass({
    propTypes: {
        onsubmit: React.PropTypes.func.isRequired,
        onChange: React.PropTypes.func.isRequired
    },

    render: function () {

        var experienceItems = [{ "text": "0-2", "value": "0" }, { "text": "2-5", "value": "2" }, { "text": "6-10", "value": "6" }, { "text": "10+", "value": "10" }];
        var ethnicityItems = [{ "text": "African American", "value": "AfricanAmerican" }, { "text": "Asian", "value": "Asian" }, { "text": "Caucasian", "value": "Caucasian" }, { "text": "Hispanic", "value": "Hispanic" }, { "text": "Native American", "value": "NativeAmerican" }, { "text": "Pacific Islander", "value": "PacificIslander" }, { "text": "Other", "value": "Other" }];
        var yesNoItems = [{ "text": "Yes", "value":"Y" }, { "text": "No", "value":"N" }];
        var genderItems = [{ "text": "Male", "value": "M" }, { "text": "Female", "value": "F" }];

        return (
           <form>
                <TextBox id="keywordInput" value={this.props.criteria.keyword} onchange={this.props.onchange} label="Keywords" inputType="search" placeholder="Skills/Keywords" />
                <Button id="submitInput" label="Search" onclick={this.props.onsubmit} /> 
                <br /> 
                <TextBox id="roleInput" label="Role" inputType="search" placeholder="Role" />
                <TextBox id="locationInput" label="Location" inputType="search" placeholder="Zip Code, City or State" />
                <MultiSelect id="experienceInput" label="Experience" inputType="checkbox" items={experienceItems} />

            <h3>Diversity Factors</h3>
                <MultiSelect id="genderInput" label="Gender" inputType="checkbox" items={genderItems} />
                <MultiSelect id="ethnicityInput" label="Ethnicity" inputType="checkbox" items={ethnicityItems} />
                <MultiSelect id="disabledInput" label="Disabled?" inputType="checkbox" items={yesNoItems} />   
                <MultiSelect id="veteranInput" label="US Military Veteran?" inputType="checkbox" items={yesNoItems} />
                <MultiSelect id="lgbtqInput" label="A Member of the LGBTQ Community" inputType="checkbox" items={yesNoItems} />            
           </form>
    );
    }
});

module.exports = SearchCriteria;