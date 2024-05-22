import axios from "axios";
import {envParams} from "../envParams";
import {AuthRequest} from "../request/AuthRequest";

export let getStat = async () => {
    const response = await axios.get((new envParams()).DOMAIN + '/api/v1/office/statistic/');
    return response.data;
}