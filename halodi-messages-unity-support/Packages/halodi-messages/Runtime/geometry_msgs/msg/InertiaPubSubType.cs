using System.IO;
namespace geometry_msgs.msg
{

/**
* 
* Topic data type of the struct "Inertia" defined in "Inertia.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from Inertia.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit Inertia.idl instead.
*
*/
public class InertiaPubSubType : Halodi.CDR.TopicDataType<Inertia>
{
   public override string Name => "geometry_msgs::msg::dds_::Inertia_";


   public static int getCdrSerializedSize(geometry_msgs.msg.Inertia data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(geometry_msgs.msg.Inertia data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += 8 + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);


      current_alignment += geometry_msgs.msg.Vector3PubSubType.getCdrSerializedSize(data.com, current_alignment);

      current_alignment += 8 + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);


      current_alignment += 8 + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);


      current_alignment += 8 + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);


      current_alignment += 8 + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);


      current_alignment += 8 + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);


      current_alignment += 8 + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);



      return current_alignment - initial_alignment;
   }

   public static void write(geometry_msgs.msg.Inertia data, Halodi.CDR.CDRSerializer cdr)
   {
      cdr.write_type_6(data.m);

      geometry_msgs.msg.Vector3PubSubType.write(data.com, cdr);

      cdr.write_type_6(data.ixx);

      cdr.write_type_6(data.ixy);

      cdr.write_type_6(data.ixz);

      cdr.write_type_6(data.iyy);

      cdr.write_type_6(data.iyz);

      cdr.write_type_6(data.izz);

   }

   public static void read(geometry_msgs.msg.Inertia data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.m=cdr.read_type_6();
      	
      data.com = geometry_msgs.msg.Vector3PubSubType.Create();
      geometry_msgs.msg.Vector3PubSubType.read(data.com, cdr);
      	
      data.ixx=cdr.read_type_6();
      	
      data.ixy=cdr.read_type_6();
      	
      data.ixz=cdr.read_type_6();
      	
      data.iyy=cdr.read_type_6();
      	
      data.iyz=cdr.read_type_6();
      	
      data.izz=cdr.read_type_6();
      	

   }


	public override void Serialize(geometry_msgs.msg.Inertia data, Halodi.CDR.CDRSerializer cdr)
   	{
   		write(data, cdr);	
   	}

	public override void Deserialize(geometry_msgs.msg.Inertia data, Halodi.CDR.CDRDeserializer cdr)
   	{
   		read(data, cdr);	
   	}
   	
   	public override int GetSize(geometry_msgs.msg.Inertia data)
   	{
   		return getCdrSerializedSize(data);
   	}

    public static void Copy(geometry_msgs.msg.Inertia src, geometry_msgs.msg.Inertia target)
    {
        target.Set(src);
    }
    
    public override void CopyTo(geometry_msgs.msg.Inertia src, geometry_msgs.msg.Inertia target)
    {
    	Copy(src, target);
    }


}


}