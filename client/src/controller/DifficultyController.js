import axios from "axios";
import {envParams} from "../envParams";
import {AgeRestrictionModel} from "../model/AgeRestrictionModel";
import {DifficultyModel} from "../model/DifficultyModel";

export let getDifficulty = async () => {
    let data;
    try {
        const response = await axios.get((new envParams()).DOMAIN + "/api/v1/office/difficulty/")
        data = response.data
    } catch (err) {
        console.error(err.toJSON())
    }

    return data.map(x => {
        let model = new DifficultyModel();
        model.id = x.id;
        model.name = x.name;

        return model;
    })
}
