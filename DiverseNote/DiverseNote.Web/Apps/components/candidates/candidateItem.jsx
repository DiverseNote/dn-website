"use strict";

var React = require('react');
var CandidateItem = React.createClass({
    render: function () {
        return (
                <div className="list-group blockItem">
                    <div className="list-group-item">                        
                        <table>
                        <tr>
                            <td className="profile-image"><img className="img-responsive img-circle" height="100" width="90" src="../../../Images/Candidates/candidateHeadshot.png" /></td>
                            <td>
                                <h3>{this.props.candidate.FirstName + " " +this.props.candidate.LastName}</h3>
                                <div>Software Engineer</div>
                                <div><span className="listItemLabel">Salary</span> $80,000 <span className="listItemLabel"> Skills</span> {this.props.skills}</div>
                            </td>
                        </tr>
                        </table>
                                               
                    </div>
                </div>
            )
    }
});

module.exports = CandidateItem;