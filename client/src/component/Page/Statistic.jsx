import React, {useEffect, useState} from 'react';
import style from './../../style/Page/Statistic.module.css'
import ColumnStatistic from "../PagePart/columnStatistic";
import {getStat} from "../../controller/StatController";
import {StatisticModel} from "../../model/StatisticModel";

const Statistic = () => {
    useEffect(() => {
        getStat().then(setData)
    }, []);

    const [data, setData] = useState(new StatisticModel());

    return (
        <div className={style.page}>
            <div className={style.statBlock}>
                <p>Разброс игр по сложности</p>
                <div className={style.columnBlock}>
                    {data.difficulty.map(
                        stat => <ColumnStatistic count={stat.count} name={stat.name} key={stat.name}/>
                    )}
                </div>
            </div>
            <div className={style.statBlock}>
                <p>Разброс игр по кол-ву игроков</p>
                <div className={style.columnBlock}>
                    {data.player_count.map(
                        stat => <ColumnStatistic count={stat.count} name={stat.name} key={stat.name}/>
                    )}
                </div>
            </div>
        </div>
    );
};

export default Statistic;