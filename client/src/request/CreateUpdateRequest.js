export class CreateUpdateRequest {
    id = null;
    name = '';
    code = this.name + "_board_game"
    active = true;
    title = '';
    description = '';
    rules = '';
    age_restriction = '';
    player_count = '';
    difficulty = ''

    constructor() {
        this.id = null;
        this.name = '';
        this.code = this.name + "_board_game"
        this.active = true;
        this.title = '';
        this.description = '';
        this.rules = '';
        this.age_restriction = '';
        this.player_count = '';
        this.difficulty = ''
    }

    clone() {
        let clone = new CreateUpdateRequest();

        clone.id = this.id;
        clone.name = this.name;
        clone.code = this.name + "_board_game"
        clone.active = this.active;
        clone.title = this.title;
        clone.description = this.description;
        clone.rules = this.rules;
        clone.age_restriction = this.age_restriction;
        clone.player_count = this.player_count;
        clone.difficulty = this.difficulty

        return clone;
    }
}
