import React, {useEffect, useState} from 'react';
import style from '../../style/Page/CreateUpdate.module.css'
import Input from "../UI/Input";
import {CreateUpdateRequest} from "../../request/CreateUpdateRequest";
import {getDifficulty} from "../../controller/DifficultyController";
import {getAgeRestrictions} from "../../controller/AgerestrictionController";
import {getPlayerCount} from "../../controller/PlayerCountController";
import Button from "../UI/Button";
import {createGame, getDetail} from "../../controller/BoardGameController";
import cross from './../../asset/cross-svgrepo-com.svg'
import {useHistory, useParams} from "react-router-dom";

const CreateUpdate = () => {
    let [request, setRequest] = useState(new CreateUpdateRequest());

    let setName = (value) => setRequest(x => {
        let clone = x.clone()
        clone.name = value;
        return clone
    });

    let setTitle = (value) => setRequest(x => {
        let clone = x.clone()
        clone.title = value;
        return clone
    });

    let setDescription = (value) => setRequest(x => {
        let clone = x.clone()
        clone.description = value;
        return clone
    });

    let setRules = (value) => setRequest(x => {
        let clone = x.clone()
        clone.rules = value;
        return clone
    });

    let save = () => {
        createGame(request);
        router.goBack();
    }

    let [diffs, setDiff] = useState([]);
    let [ageRestrictions, setAgeRestrictions] = useState([]);
    let [playerCounts, setPlayerCounts] = useState([]);

    useEffect( () => {
        EffectAsync()
        if (params.id != null) {
            setRequestFromDetail(params.id)
        }
    }, []);


    let setRequestFromDetail = async(id) => {
        setRequest(await getDetail(id))
    }

    let EffectAsync = async () => {
        setDiff(await getDifficulty());
        setAgeRestrictions(await getAgeRestrictions());
        setPlayerCounts(await getPlayerCount());
    }


    function closeModal() {
        let modal = document.getElementById('ModalOpen');
        modal.style.display = 'none';
    }


    const router = useHistory();


    let params = useParams();




    return (<div className={style.wrapper}>
            <div className={style.modalWindow}>
                    <Button
                        content={
                            <img
                                src={cross}
                                alt="Закрыть"
                                height="24px"
                                width="24px"
                            />
                        }
                        action={router.goBack}
                    />
                <Input
                    name="Cистемное имя"
                    value={request.name}
                    onChange={setName}
                />
                <Input
                    name="Назавние настольной игры"
                    value={request.title}
                    onChange={setTitle}
                />
                <Input
                    name="Описание"
                    value={request.description}
                    onChange={setDescription}
                />
                <Input
                    name="Правила игры"
                    value={request.rules}
                    onChange={setRules}
                />

                <select
                    value={request.difficulty}
                    onChange={event => setRequest(x => {
                        let clone = x.clone()
                        clone.difficulty = event.target.value;
                        return clone
                    })}
                >
                    <option value={null}>Выбирите сложность</option>
                    {diffs.map(x =>
                        <option value={x.id}>{x.name}</option>
                    )}
                </select>

                <select
                    value={request.age_restriction}
                    onChange={event => setRequest(x => {
                        let clone = x.clone()
                        clone.age_restriction = event.target.value;
                        return clone
                    })}
                >
                    <option value={null}>Возврастное ограниечение</option>
                    {ageRestrictions.map(x =>
                        <option value={x.id}>{x.text}</option>
                    )}
                </select>

                <select
                    value={request.player_count}
                    onChange={event => setRequest(x => {
                        let clone = x.clone()
                        clone.player_count = event.target.value;
                        return clone
                    })}
                >
                    <option value={null}>Кол-во игроков</option>
                    {playerCounts.map(x =>
                        <option value={x.id}>{x.text}</option>
                    )}
                </select>

                <Button
                    content={params.id == null ? "Создать" : "Обновить"}
                    action={save}
                />
            </div>
        </div>);
};

export default CreateUpdate;