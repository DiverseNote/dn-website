var alt = require('../alt');
var CandidateActions = require('../actions/CandidateActions');

class CandidateStore {
    constructor() {
        this.candidate = {};

        this.bindListeners({
            handleAddCandidate: CandidateActions.ADD_CANDIDATE
        });
    }

    handleAddCandidate(candidate) {
        this.candidate = candidate;
    }
}

module.exports = alt.createStore(CandidateStore, 'CandidateStore');