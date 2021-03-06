using Assets.Scripts.GameLogic;
using System;

namespace behaviac
{
	internal class Condition_bt_WrapperAI_Hero_HeroCommonAutoAI_node1154 : Condition
	{
		protected override EBTStatus update_impl(Agent pAgent, EBTStatus childStatus)
		{
			ObjDeadMode actorDeadState = ((ObjAgent)pAgent).GetActorDeadState();
			ObjDeadMode objDeadMode = ObjDeadMode.DeadState_Move;
			return (actorDeadState == objDeadMode) ? EBTStatus.BT_SUCCESS : EBTStatus.BT_FAILURE;
		}
	}
}
