import React from 'react';
import style from './../../style/PagePart/ColumnStatistic.module.css';

const ColumnStatistic = (props) => {
    let height = 10 * props.count

    return (
        <div className={style.wrapper}>
            <div
                style={
                    {
                        height: height,
                        backgroundColor: getRandomColor()
                    }
                }
            >
            </div>
            <p>{props.name}</p>
            <p>{props.count}</p>
        </div>
    );
};

function getRandomColor() {
    var letters = '0123456789ABCDEF';
    var color = '#';
    for (var i = 0; i < 6; i++) {
        color += letters[Math.floor(Math.random() * 16)];
    }
    return color;
}

export default ColumnStatistic;