import React from 'react';
import style from './../../style/UI/Input.module.css'

const Input = (props) => {


    return (
        <div className={style.wrapper}>
            <p className={style.text}>{props.name}</p>
            <input
                className={style.input}
                value={props.value}
                onChange={event => props.onChange(event.target.value)}
                type={props.type}
            />
        < /div>
    );
}

export default Input;