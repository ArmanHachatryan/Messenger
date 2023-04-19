import React, { useState } from 'react'
import Messages from '../components/Messagess'
import Message from '../components/Message';
import CreateMessage from '../components/CreateMessage';



export default function MessageHistory() {
  const [selectedMessage, setSelectedMessage]= useState(null);

  return (
    <>
        <Messages setSelectedMessage={setSelectedMessage}/>

        <hr />

        <Message selectedMessage={selectedMessage}/>

        <hr/>

        <CreateMessage/>

    </>
  )
}
