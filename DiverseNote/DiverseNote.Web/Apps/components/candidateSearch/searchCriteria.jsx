"use strict";

var React = require('react');
var TextBox = require('../Common/InputControls/textbox.jsx');
var MultiSelect = require('../Common/InputControls/multiselect.jsx');
var Select = require('../Common/InputControls/select.jsx');
var Button = require('../common/InputControls/button.jsx');

var SearchCriteria = React.createClass({
    propTypes: {
        onsubmit: React.PropTypes.func.isRequired,
        onchange: React.PropTypes.func.isRequired
    },

    render: function () {

        var experienceItems = [{ "label": "Junior", "value": "junior" }, { "label": "Intermediate", "value": "intermediate" }, { "label": "Senior", "value": "senior" }, { "label": "Executive", "value": "executive" }];
        var ethnicityItems = [{ "label": "African American", "value": "africanamerican" }, { "label": "Asian", "value": "asian" }, { "label": "Caucasian", "value": "caucasian" }, { "label": "Hispanic", "value": "hispanic" }, { "label": "Native American", "value": "nativeamerican" }, { "label": "Pacific Islander", "value": "pacificislander" }, { "label": "Other", "value": "other" }];
        var genderItems = [{ "label": "Male", "value": "male" }, { "label": "Female", "value": "female" }];
        var otherClassifications = [{"label" :"Disabled", "value" : "disabled"}, {"label" : "US Military Veteran", "value" : "veteran"}, {"label" : "A Member of the LGBTQ Community", "value" : "lgbtq"}];

        return (
           <form>
                <TextBox id="keywordInput" value={this.props.criteria.keywords} propname="keywords" onchange={this.props.onchange} label="Keywords" inputType="search" placeholder="Skills/Keywords" />
                <MultiSelect id="experienceInput" propname="experience" label="Experience" onchange={this.props.onchange} items={experienceItems} />

            <h3>Diversity Factors</h3>
                <MultiSelect id="genderInput" label="Gender" propname="gender" onchange={this.props.onchange} items={genderItems} />
                <MultiSelect id="ethnicityInput" label="Ethnicity" propname="ethnicity" onchange={this.props.onchange} items={ethnicityItems} />
                <MultiSelect id="disabledInput" label="Other Classifications" propname="other" onchange={this.props.onchange} items={otherClassifications} />  
           
                <Button id="submitInput" submit="true" label="Search" onclick={this.props.onsubmit} />
           </form>
    );
    }
});

module.exports = SearchCriteria;