using System.IO;
namespace actionlib_msgs.msg
{

/**
* 
* Topic data type of the struct "GoalStatusArray" defined in "GoalStatusArray.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from GoalStatusArray.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit GoalStatusArray.idl instead.
*
*/
public class GoalStatusArrayPubSubType : Halodi.CDR.TopicDataType<GoalStatusArray>
{
   public override string Name => "actionlib_msgs::msg::dds_::GoalStatusArray_";


   public static int getCdrSerializedSize(actionlib_msgs.msg.GoalStatusArray data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(actionlib_msgs.msg.GoalStatusArray data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += std_msgs.msg.HeaderPubSubType.getCdrSerializedSize(data.header, current_alignment);

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      for(int i0 = 0; i0 < data.status_list.Count; ++i0)
      {
          current_alignment += actionlib_msgs.msg.GoalStatusPubSubType.getCdrSerializedSize(data.status_list[i0], current_alignment);}


      return current_alignment - initial_alignment;
   }

   public static void write(actionlib_msgs.msg.GoalStatusArray data, Halodi.CDR.CDRSerializer cdr)
   {
      std_msgs.msg.HeaderPubSubType.write(data.header, cdr);

      	if(data.status_list == null)
      	{
      		cdr.write_type_2(0);
      	}
      	else
      	{

      	  int status_list_length = data.status_list.Count;
            cdr.write_type_2(status_list_length);
            for (int i0 = 0; i0 < status_list_length; i0++)
            {
      			actionlib_msgs.msg.GoalStatusPubSubType.write(data.status_list[i0], cdr);	      }
        }
   }

   public static void read(actionlib_msgs.msg.GoalStatusArray data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.header = std_msgs.msg.HeaderPubSubType.Create();
      std_msgs.msg.HeaderPubSubType.read(data.header, cdr);
      	

      int status_list_length = cdr.read_type_2();
      data.status_list = new System.Collections.Generic.List<actionlib_msgs.msg.GoalStatus>(status_list_length);
      for(int i = 0; i < status_list_length; i++)
      {
      	actionlib_msgs.msg.GoalStatus new_status_list = actionlib_msgs.msg.GoalStatusPubSubType.Create(); 
      	actionlib_msgs.msg.GoalStatusPubSubType.read(new_status_list, cdr);
      	data.status_list.Add(new_status_list);	
      	
      }

      	

   }


	public override void Serialize(actionlib_msgs.msg.GoalStatusArray data, Halodi.CDR.CDRSerializer cdr)
   	{
   		write(data, cdr);	
   	}

	public override void Deserialize(actionlib_msgs.msg.GoalStatusArray data, Halodi.CDR.CDRDeserializer cdr)
   	{
   		read(data, cdr);	
   	}
   	
   	public override int GetSize(actionlib_msgs.msg.GoalStatusArray data)
   	{
   		return getCdrSerializedSize(data);
   	}

    public static void Copy(actionlib_msgs.msg.GoalStatusArray src, actionlib_msgs.msg.GoalStatusArray target)
    {
        target.Set(src);
    }
    
    public override void CopyTo(actionlib_msgs.msg.GoalStatusArray src, actionlib_msgs.msg.GoalStatusArray target)
    {
    	Copy(src, target);
    }


}


}