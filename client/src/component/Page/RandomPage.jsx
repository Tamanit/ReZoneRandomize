import React, {useEffect, useState} from 'react';
import HeaderForRand from "../PagePart/HeaderForRand";
import style from "../../style/Page/RandomPage.module.css";
import Button from "../UI/Button";
import FooterForRand from "../PagePart/FooterForRand";
import {getRandomGame} from "../../controller/BoardGameController";
import {useHistory, useParams} from "react-router-dom";

const RandomPage = () => {

    let params = useParams();
    let [game, setGame] = useState({id: '', name: ''});

    useEffect(
        () => {getRandomGame(params.branchName).then(setGame)}, []
    );

    return (
        <div className={style.randomPage}>
            <HeaderForRand></HeaderForRand>
            <div className={style.wrapper}>
                <div className={style.boardGameName}>{game.name}</div>
                <Button
                    content="Испытать удачу"
                    action={() => {getRandomGame(params.branchName).then(setGame)}}
                />
            </div>
            <FooterForRand/>
        </div>
    );
};

export default RandomPage;