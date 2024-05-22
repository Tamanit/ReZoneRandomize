import React, {useEffect, useState} from 'react';
import style from './../../style/PagePart/RepositoryItem.module.css'
import Button from "../UI/Button";
import {PaginationModel} from "../../model/paginationModel";
import bin from './../../asset/Bin.svg'
import eye from './../../asset/Eye.svg'
import CreateUpdate from "../Page/CreateUpdate";
import {useHistory} from "react-router-dom";

const RepositoryItem = (props) => {

    let deleteAction = () => props.actonDelete(props.id)

    let router = useHistory();

    return (
        <div className={style.wrapper}>
            <div className={style.textBlock}>
                <p>{props.listingItem.name}</p>
                <p>{props.listingItem.title}</p>
            </div>
            <p className={style.textBlock} >{props.listingItem.age_restriction.text}</p>
            <p className={style.textBlock}>{props.listingItem.difficulty.name}</p>
            <p className={style.textBlock}>{props.listingItem.player_count.text}</p>
            <div className={style.buttonBlock}>
                <Button
                    content={
                        <img
                            src={eye}
                            alt="это глаз"
                            height="24px"
                            width="24px"
                        />
                    }
                    action={() => router.push(`/boardGames/${props.id}`)}
                />
                <Button
                    action={deleteAction}
                    content={
                        <img
                            src={bin}
                            alt="это мусорка"
                            height="24px"
                            width="24px"
                        />
                    }
                />
            </div>
        </div>
    );
};

export default RepositoryItem;