import React, {useEffect, useState} from 'react';
import style from '../../style/PagePart/RepoControlPanel.module.css'
import Button from "../UI/Button";
import LeftArrow from '../../asset/LeftArrow.svg'
import RightArrow from '../../asset/RightArrow.svg'
import Plus from '../../asset/Plus.svg'
import {PaginationModel} from "../../model/paginationModel";
import RedirectButton from "../UI/RedirectButton";
import {download} from "../../controller/ExportController";

const RepoControlPanel = (props) => {

    useEffect(() => {
        setPagination(props.pagination)
    }, [props.pagination]);

    let [pagination, setPagination] = useState(new PaginationModel());

    return (
        <div className={style.plate}>
            <div className={style.pageButtons}>
                <Button
                    action={props.prewPage}
                    content={
                        <img
                            src={LeftArrow}
                            alt="Profile picture"
                            height="24px"
                            width="24px"
                        />
                    }

                />

                <p>{pagination.page} из {pagination.pages}</p>
                <Button
                    action={props.nextPage}
                    content={
                        <img
                            src={RightArrow}
                            alt="Profile picture"
                            height="24px"
                            width="24px"
                        />
                    }/>
            </div>
            <Button
                action={download}
                content="Экспорт"

            />
            <RedirectButton
                to="boardGame/create"
                content={
                <img
                    src={Plus}
                    alt="Profile picture"
                    height="24px"
                    width="24px"
                />
            }
            />
        </div>
    );
};

export default RepoControlPanel;