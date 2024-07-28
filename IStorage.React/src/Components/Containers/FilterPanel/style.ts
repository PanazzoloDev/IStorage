import styled from "styled-components";

interface filterPanelContainerProps {
    open: boolean;
}

const FilterPanelContainer = styled.div<filterPanelContainerProps>`
    flex: none;
    flex-direction: column;
    height: 100%;
    background-color: #eb3f24;
    width: ${props => props.open? '320px;' : '60px;'};
    transition: 1s;
`

export {
    FilterPanelContainer,
}