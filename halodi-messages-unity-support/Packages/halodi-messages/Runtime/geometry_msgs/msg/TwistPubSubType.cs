using System.IO;
namespace geometry_msgs.msg
{

/**
* 
* Topic data type of the struct "Twist" defined in "Twist.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from Twist.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit Twist.idl instead.
*
*/
public class TwistPubSubType : Halodi.CDR.TopicDataType<Twist>
{
   public override string Name => "geometry_msgs::msg::dds_::Twist_";


   public static int getCdrSerializedSize(geometry_msgs.msg.Twist data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(geometry_msgs.msg.Twist data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += geometry_msgs.msg.Vector3PubSubType.getCdrSerializedSize(data.linear, current_alignment);

      current_alignment += geometry_msgs.msg.Vector3PubSubType.getCdrSerializedSize(data.angular, current_alignment);


      return current_alignment - initial_alignment;
   }

   public static void write(geometry_msgs.msg.Twist data, Halodi.CDR.CDRSerializer cdr)
   {
      geometry_msgs.msg.Vector3PubSubType.write(data.linear, cdr);

      geometry_msgs.msg.Vector3PubSubType.write(data.angular, cdr);

   }

   public static void read(geometry_msgs.msg.Twist data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.linear = geometry_msgs.msg.Vector3PubSubType.Create();
      geometry_msgs.msg.Vector3PubSubType.read(data.linear, cdr);
      	
      data.angular = geometry_msgs.msg.Vector3PubSubType.Create();
      geometry_msgs.msg.Vector3PubSubType.read(data.angular, cdr);
      	

   }


	public override void Serialize(geometry_msgs.msg.Twist data, Halodi.CDR.CDRSerializer cdr)
   	{
   		write(data, cdr);	
   	}

	public override void Deserialize(geometry_msgs.msg.Twist data, Halodi.CDR.CDRDeserializer cdr)
   	{
   		read(data, cdr);	
   	}
   	
   	public override int GetSize(geometry_msgs.msg.Twist data)
   	{
   		return getCdrSerializedSize(data);
   	}

    public static void Copy(geometry_msgs.msg.Twist src, geometry_msgs.msg.Twist target)
    {
        target.Set(src);
    }
    
    public override void CopyTo(geometry_msgs.msg.Twist src, geometry_msgs.msg.Twist target)
    {
    	Copy(src, target);
    }


}


}