import axios from "axios";
import {envParams} from "../envParams";
import {PaginationModel} from "../model/paginationModel";
import {ListingElementsModel} from "../model/listingElementsModel";
import {ListModel} from "../model/listModel";
import {AgeRestrictionModel} from "../model/AgeRestrictionModel";
import {DifficultyModel} from "../model/DifficultyModel";
import {PlayerCountModel} from "../model/PlayerCountModel";
import {CreateUpdateRequest} from "../request/CreateUpdateRequest";

export let getListing = async () => {
    const response = await axios.get((new envParams()).DOMAIN + "/api/v1/office/boardGames/")
    return response.data;
}

export let changePage = async (page) => {
    const response = await axios.get((new envParams()).DOMAIN + "/api/v1/office/boardGames/?page=" + page)
    return (response.data);
}


export let setupDataListing = (data) => {
    let pagination = new PaginationModel();
    pagination.page = data.pagination.page;
    pagination.page_size = data.pagination.page_size;
    pagination.pages = data.pagination.pages;

    let listingElements = data.list.map((element) => {
        let listingModel = new ListingElementsModel();
        listingModel.id = element.id;
        listingModel.name = element.name;
        listingModel.title = element.title;
        listingModel.detail_link = element.detail_link;
        listingModel.ageRestriction = new AgeRestrictionModel();
        listingModel.ageRestriction.id = element.age_restriction.id;
        listingModel.ageRestriction.text = element.age_restriction.text;
        listingModel.difficulty = new DifficultyModel();
        listingModel.difficulty.id = element.difficulty.id;
        listingModel.difficulty.name = element.difficulty.name;
        listingModel.difficulty.code = element.difficulty.code;
        listingModel.difficulty.level = element.difficulty.level;
        listingModel.playerCount = new PlayerCountModel();
        listingModel.playerCount.id = element.player_count.id;
        listingModel.playerCount.text = element.player_count.text;

        return listingModel;
    });
    console.log(listingElements);

    let returnableModel = new ListModel();
    returnableModel.pagination = pagination;
    returnableModel.list = listingElements;


    return returnableModel;
}

export let deleteItem = async (id, page) => {
    await axios.delete((new envParams()).DOMAIN + "/api/v1/office/boardGame/trashBin/" + id)
    return changePage(page)
}

export let getDetail = async (id) => {
    let data;
    try {
        const response = await axios.get((new envParams()).DOMAIN + '/api/v1/office/boardGame/' + id)
        data = response.data
    } catch (err) {
        console.error(err.toJSON())
    }
    let detail = new CreateUpdateRequest();

    detail.id = data.id;
    detail.name = data.name;
    detail.title = data.title;
    detail.description = data.description;
    detail.rules = data.rules;
    detail.age_restriction = data.age_restriction.id;
    detail.player_count = data.player_count.id;
    detail.difficulty = data.difficulty.id;

    return detail;
}

export let createGame = async (request) => {
    (await axios.patch((new envParams()).DOMAIN + '/api/v1/office/boardGame/workbench', request, {headers: {'Content-Type': 'application/json'}}))
}

export let getRandomGame = async (branchName) => {
    console.log(branchName);
    branchName = branchName === undefined ? '' : branchName;
    console.log(branchName);
    const response = await axios.get(
        new envParams().DOMAIN + '/api/v1/random/?branch=' + branchName,
        {
            headers: {
                'Access-Control-Allow-Origin' : 'http://srv-captain--rezone-random/'
            }
        }
        );
    return response.data;
}