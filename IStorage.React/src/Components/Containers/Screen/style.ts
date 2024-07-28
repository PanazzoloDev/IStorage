import styled from "styled-components"

const ScreenContainer = styled.div`
    height: 100vh;
    width: 100vw;
    display: flex;
    flex-direction:column;
`

const ContentScreen = styled.main`
    flex: 1;
    overflow-y: auto;
    display: flex;
    flex-direction: row;
`

export {
    ScreenContainer,
    ContentScreen
}