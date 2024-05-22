import axios from "axios";
import {envParams} from "../envParams";
import {AuthRequest} from "../request/AuthRequest";

export let sendRequestToLogin = async (login, password) => {
        let data;
        try {
            const response = await axios.post((new envParams()).DOMAIN + '/api/v1/auth', new AuthRequest(login, password), {headers: {'Content-Type': 'application/json'}})
            data = response.data
        } catch (err) {
        console.error(err.toJSON())
    }
    return data.token;
}

export let setRequestFromRegister = async (login, password) => {
    let data;
    try {
        const response = await axios.post((new envParams()).DOMAIN + '/api/v1/register', new AuthRequest(login, password), {headers: {'Content-Type': 'application/json'}})
        data = response.data
    } catch (err) {
        console.error(err.toJSON())
    }
    return data.token;
}