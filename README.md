# SAFE-node18.2-elmish-react

Steps:
1) Create SAFE project
2) Upgrade to react 18.2 (Works fine)
3) Add a react component ([<ReactComponent>])

react-dom.development.js:16227 Uncaught Error: Invalid hook call. Hooks can only be called inside of the body of a function component. This could happen for one of the following reasons:
1. You might have mismatching versions of React and the renderer (such as React DOM)
2. You might be breaking the Rules of Hooks
3. You might have more than one copy of React in the same app
See https://reactjs.org/link/invalid-hook-call for tips about how to debug and fix this problem.
    at Object.throwInvalidHookError (react-dom.development.js:16227:1)
    at Object.useState (react.development.js:1622:1)
    at Feliz_React__React_useState_Static_1505 (React.fs:652:51)
    at Counter (Index.fs:91:29)
    at view (Index.fs:125:29)
    at eval (Util.js:514:1)
    at uncurried (Util.js:505:1)
    at Object.eval [as render] (common.fs:92:34)
    at Components_LazyView$1.render (common.fs:55:17)
    at finishClassComponent (react-dom.development.js:19752:1)
react-dom.development.js:18687 The above error occurred in the <Components_LazyView$1> component:

    at Components_LazyView$1 (webpack-internal:///135:55:9)

Consider adding an error boundary to your tree to customize error handling behavior.
Visit https://reactjs.org/link/error-boundaries to learn more about error boundaries.
l
