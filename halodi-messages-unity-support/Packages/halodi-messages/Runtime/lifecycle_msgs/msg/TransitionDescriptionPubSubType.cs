using System.IO;
namespace lifecycle_msgs.msg
{

/**
* 
* Topic data type of the struct "TransitionDescription" defined in "TransitionDescription.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from TransitionDescription.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit TransitionDescription.idl instead.
*
*/
public class TransitionDescriptionPubSubType : Halodi.CDR.TopicDataType<TransitionDescription>
{
   public override string Name => "lifecycle_msgs::msg::dds_::TransitionDescription_";


   
   public override void serialize(lifecycle_msgs.msg.TransitionDescription data, MemoryStream stream)
   {
   	  using(BinaryWriter writer = new BinaryWriter(stream))
   	  {
   	  	  Halodi.CDR.CDRSerializer cdr = new Halodi.CDR.CDRSerializer(writer);
   	  	  write(data, cdr); 
   	  }
   }

   
   public override void deserialize(MemoryStream stream, lifecycle_msgs.msg.TransitionDescription data)
   {
   	   using(BinaryReader reader = new BinaryReader(stream))
   	   {
   	   		Halodi.CDR.CDRDeserializer cdr = new Halodi.CDR.CDRDeserializer(reader);
   	   		read(data, cdr); 
   	   }
   }

   public static int getCdrSerializedSize(lifecycle_msgs.msg.TransitionDescription data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(lifecycle_msgs.msg.TransitionDescription data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += lifecycle_msgs.msg.TransitionPubSubType.getCdrSerializedSize(data.transition, current_alignment);

      current_alignment += lifecycle_msgs.msg.StatePubSubType.getCdrSerializedSize(data.start_state, current_alignment);

      current_alignment += lifecycle_msgs.msg.StatePubSubType.getCdrSerializedSize(data.goal_state, current_alignment);


      return current_alignment - initial_alignment;
   }

   public static void write(lifecycle_msgs.msg.TransitionDescription data, Halodi.CDR.CDRSerializer cdr)
   {
      lifecycle_msgs.msg.TransitionPubSubType.write(data.transition, cdr);

      lifecycle_msgs.msg.StatePubSubType.write(data.start_state, cdr);

      lifecycle_msgs.msg.StatePubSubType.write(data.goal_state, cdr);

   }

   public static void read(lifecycle_msgs.msg.TransitionDescription data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.transition = lifecycle_msgs.msg.TransitionPubSubType.Create();
      lifecycle_msgs.msg.TransitionPubSubType.read(data.transition, cdr);
      	
      data.start_state = lifecycle_msgs.msg.StatePubSubType.Create();
      lifecycle_msgs.msg.StatePubSubType.read(data.start_state, cdr);
      	
      data.goal_state = lifecycle_msgs.msg.StatePubSubType.Create();
      lifecycle_msgs.msg.StatePubSubType.read(data.goal_state, cdr);
      	

   }


    public static void Copy(lifecycle_msgs.msg.TransitionDescription src, lifecycle_msgs.msg.TransitionDescription target)
    {
        target.Set(src);
    }


}


}