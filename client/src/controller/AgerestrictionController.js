import axios from "axios";
import {envParams} from "../envParams";
import {AgeRestrictionModel} from "../model/AgeRestrictionModel";

export let getAgeRestrictions = async () => {
    let data;
    try {
        const response = await axios.get((new envParams()).DOMAIN + "/api/v1/office/ageRestriction/")
        data = response.data
    } catch (err) {
        console.error(err.toJSON())
    }

    return data.map(x => {
        let model = new AgeRestrictionModel();
        model.id = x.id;
        model.text = x.text;

        return model;
    })
}
