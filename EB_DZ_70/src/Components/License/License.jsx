import React from "react";
import { Wrapper } from "../Wrapper/Wrapper";
import '../../Assets/Components/license.scss';

export const License = () =>
{
    return (
        <div className="license-wrapper">
            <Wrapper Component={<div className="div-license">TheBox Company © 2022. All Rights Reserved</div>}/>
        </div>
    )
}