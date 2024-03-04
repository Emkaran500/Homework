import React from "react";
import { ListOption } from "./ListOption/ListOption";

export const DataList = () =>
{
    return (
        <div>
            <input className="form-input" list="suggestionList" placeholder="Reason for Contacting*"/>
            <datalist id="suggestionList">
                <ListOption value={'Unknown'}/>
            </datalist>
        </div>
    )
}