import styled from "styled-components";

interface filterPanelContainerProps {
    open: boolean;
}

const FilterPanelContainer = styled.div<filterPanelContainerProps>`
    display: flex;
    flex-direction: column;
    height: 100%;
    background-color: #eb3f24;
    width: ${props => props.open? '380px;' : '80px;'};
    transition: 1s;
`

export {
    FilterPanelContainer,
}