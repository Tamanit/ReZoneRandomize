import React, {useEffect, useState} from 'react';
import style from '../../style/Page/Repository.module.css'
import RepoControlPanel from "../PagePart/RepoControlPanel";
import {changePage, deleteItem, getListing} from "../../controller/BoardGameController";
import {ListModel} from "../../model/listModel";
import RepositoryItem from "../PagePart/RepositoryItem";
import CreateUpdate from "./CreateUpdate";
const Repository = () => {
    let [repoData, setRepoData] = useState(new ListModel());

    useEffect(  () => {
        getListing().then(setRepoData)
    }, []);

    let increasePage = async () => setRepoData(await changePage(repoData.pagination.page + 1));
    let decreasePage = async () => setRepoData(await changePage(repoData.pagination.page - 1));

    let deleteBoardGame = async (id) => setRepoData(await deleteItem(id, repoData.pagination.page));

    return (
        <div className={style.page}>
            <RepoControlPanel
                pagination={repoData.pagination}
                nextPage={increasePage}
                prewPage={decreasePage}
            />
            {repoData.list.map((listingItem) => {
                return <RepositoryItem
                    listingItem={listingItem}
                    id={listingItem.id}
                    key={listingItem.id}
                    actonDelete={deleteBoardGame}
                />
            })}
        </div>
    );
};

export default Repository;