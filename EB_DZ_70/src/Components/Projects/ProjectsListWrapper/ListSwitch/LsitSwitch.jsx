import React from "react";
import { SwitchButton } from "./SwitchButton/SwitchButton";
import { CurrentPlace } from "./CurrentPlace/CurrentPlace";

export const ListSwitch = () =>
{
    return (
        <div className="list-switch">
            <SwitchButton label={'Back'}/>
            <CurrentPlace/>
            <SwitchButton label={'Next'}/>
        </div>
    )
}