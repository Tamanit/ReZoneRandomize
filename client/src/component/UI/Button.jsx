import React from "react";
import style from "../../style/UI/Button.module.css"

let Button = (props) => {

    return (
        <button
            className={style.button}
            onClick={props.action}
        >
            {props.content}
        </button>
    )
}

export default Button;
