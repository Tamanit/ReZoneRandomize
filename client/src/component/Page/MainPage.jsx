import React from 'react';
import cat from '../../asset/dancingCat.gif'
import style from '../../style/Page/MainPage.module.css'

const MainPage = () => {
    return (
        <div
            className={style.main}
        >
            <img
                className={style.img}
                src={cat}
                alt='гиганский кот'
            />
        </div>
    );
};

export default MainPage;