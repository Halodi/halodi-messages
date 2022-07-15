using System.IO;
namespace halodi_msgs.msg
{

/**
* 
* Topic data type of the struct "ControlInputState" defined in "ControlInputState.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from ControlInputState.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit ControlInputState.idl instead.
*
*/
public class ControlInputStatePubSubType : Halodi.CDR.TopicDataType<ControlInputState>
{
   public override string Name => "halodi_msgs::msg::dds_::ControlInputState_";


   
   public override void serialize(halodi_msgs.msg.ControlInputState data, MemoryStream stream)
   {
   	  using(BinaryWriter writer = new BinaryWriter(stream))
   	  {
   	  	  Halodi.CDR.CDRSerializer cdr = new Halodi.CDR.CDRSerializer(writer);
   	  	  write(data, cdr); 
   	  }
   }

   
   public override void deserialize(MemoryStream stream, halodi_msgs.msg.ControlInputState data)
   {
   	   using(BinaryReader reader = new BinaryReader(stream))
   	   {
   	   		Halodi.CDR.CDRDeserializer cdr = new Halodi.CDR.CDRDeserializer(reader);
   	   		read(data, cdr); 
   	   }
   }

   public static int getCdrSerializedSize(halodi_msgs.msg.ControlInputState data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(halodi_msgs.msg.ControlInputState data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);



      return current_alignment - initial_alignment;
   }

   public static void write(halodi_msgs.msg.ControlInputState data, Halodi.CDR.CDRSerializer cdr)
   {
      cdr.write_type_2(data.state);

   }

   public static void read(halodi_msgs.msg.ControlInputState data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.state=cdr.read_type_2();
      	

   }


    public static void Copy(halodi_msgs.msg.ControlInputState src, halodi_msgs.msg.ControlInputState target)
    {
        target.Set(src);
    }


}


}