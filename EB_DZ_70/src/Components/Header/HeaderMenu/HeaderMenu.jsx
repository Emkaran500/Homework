import React from "react";
import { HeaderMenuItem } from "./HeaderMenuItem/HeaderMenuItem";

export const HeaderMenu = () =>
{
    return (
        <ul className="topmenu">
            <HeaderMenuItem label={'Home'}/>
            <HeaderMenuItem label={'About Us'}/>
            <HeaderMenuItem label={'Projects'}/>
            <HeaderMenuItem label={'Services'}/>
            <HeaderMenuItem label={'Contact Us'}/>
        </ul>
    )
}