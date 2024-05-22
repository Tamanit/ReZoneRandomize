import axios from "axios";
import {envParams} from "../envParams";
import {PlayerCountModel} from "../model/PlayerCountModel";

export let getPlayerCount = async () => {
    let data;
    try {
        const response = await axios.get((new envParams()).DOMAIN + "/api/v1/office/playerCount/")
        data = response.data
    } catch (err) {
        console.error(err.toJSON())
    }

    return data.map(x => {
        let model = new PlayerCountModel();
        model.id = x.id;
        model.text = x.text;

        return model;
    })
}
