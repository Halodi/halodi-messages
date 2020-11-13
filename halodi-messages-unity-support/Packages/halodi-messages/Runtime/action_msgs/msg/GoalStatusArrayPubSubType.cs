using System.IO;
namespace action_msgs.msg
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
   public override string Name => "action_msgs::msg::dds_::GoalStatusArray_";


   
   public override void serialize(action_msgs.msg.GoalStatusArray data, MemoryStream stream)
   {
   	  using(BinaryWriter writer = new BinaryWriter(stream))
   	  {
   	  	  Halodi.CDR.CDRSerializer cdr = new Halodi.CDR.CDRSerializer(writer);
   	  	  write(data, cdr); 
   	  }
   }

   
   public override void deserialize(MemoryStream stream, action_msgs.msg.GoalStatusArray data)
   {
   	   using(BinaryReader reader = new BinaryReader(stream))
   	   {
   	   		Halodi.CDR.CDRDeserializer cdr = new Halodi.CDR.CDRDeserializer(reader);
   	   		read(data, cdr); 
   	   }
   }

   public static int getCdrSerializedSize(action_msgs.msg.GoalStatusArray data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(action_msgs.msg.GoalStatusArray data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      for(int i0 = 0; i0 < data.status_list.Count; ++i0)
      {
          current_alignment += action_msgs.msg.GoalStatusPubSubType.getCdrSerializedSize(data.status_list[i0], current_alignment);}

      return current_alignment - initial_alignment;
   }

   public static void write(action_msgs.msg.GoalStatusArray data, Halodi.CDR.CDRSerializer cdr)
   {
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
      			action_msgs.msg.GoalStatusPubSubType.write(data.status_list[i0], cdr);	      }
        }   }

   public static void read(action_msgs.msg.GoalStatusArray data, Halodi.CDR.CDRDeserializer cdr)
   {

      int status_list_length = cdr.read_type_2();
      data.status_list = new System.Collections.Generic.List<action_msgs.msg.GoalStatus>(status_list_length);
      for(int i = 0; i < status_list_length; i++)
      {
      	action_msgs.msg.GoalStatus new_status_list = action_msgs.msg.GoalStatusPubSubType.Create(); 
      	action_msgs.msg.GoalStatusPubSubType.read(new_status_list, cdr);
      	data.status_list.Add(new_status_list);	
      	
      }

      	

   }


    public static void Copy(action_msgs.msg.GoalStatusArray src, action_msgs.msg.GoalStatusArray target)
    {
        target.Set(src);
    }


}


}