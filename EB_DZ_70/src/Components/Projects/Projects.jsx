import React from "react";
import { ProjectsMenu } from "./ProjectsMenu/ProjectsMenu";
import { ProjectsListWrapper } from "./ProjectsListWrapper/ProjectsListWrapper";
import '../../Assets/Components/projects.scss';

export const Projects = () =>
{
    return (
        <div className="projects-wrapper">
            <div className="projects-title">Projects</div>
            <div className="projects-body">
                <ProjectsMenu/>
                <ProjectsListWrapper/>
            </div>
        </div>
    )
}