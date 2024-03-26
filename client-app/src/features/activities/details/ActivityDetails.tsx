import React from 'react'
import { Activity } from '../../../app/models/activity'
import {CardMeta, CardHeader,CardDescription,CardContent,Card,Icon,Image, Button, } from 'semantic-ui-react'


 interface Props{
    activity:Activity;
    cancelSelectActivity:()=>void;
    openForm:(id:string)=>void;
 }
export default function ({activity, cancelSelectActivity, openForm}:Props) {
  return (
    <Card fluid>
    <Image src= {`/assets/categoryImages/${activity.category}.jpg`} wrapped ui={false} />
    <CardContent>
      <CardHeader>{activity.title}</CardHeader>
      <CardMeta>
        <span>{activity.date}</span>
      </CardMeta>
      <CardDescription>
        {activity.description}
      </CardDescription>
    </CardContent>
    <CardContent extra>
        <Button.Group widths='2'>
            <Button basic color='blue' content='Edit' onClick={()=>openForm(activity.id)} />
            <Button onClick={cancelSelectActivity} basic color='grey' content='Cancel' />
        </Button.Group>
    </CardContent>
  </Card>
  )
}
