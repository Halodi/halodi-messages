// generated from rosidl_typesupport_introspection_c/resource/idl__type_support.c.em
// with input from halodi_msgs:msg/ExtrinsicCalibrationInfo.idl
// generated code does not contain a copyright notice

#include <stddef.h>
#include "halodi_msgs/msg/extrinsic_calibration_info__rosidl_typesupport_introspection_c.h"
#include "halodi_msgs/msg/rosidl_typesupport_introspection_c__visibility_control.h"
#include "rosidl_typesupport_introspection_c/field_types.h"
#include "rosidl_typesupport_introspection_c/identifier.h"
#include "rosidl_typesupport_introspection_c/message_introspection.h"
#include "halodi_msgs/msg/extrinsic_calibration_info__functions.h"
#include "halodi_msgs/msg/extrinsic_calibration_info__struct.h"


// Include directives for member types
// Member `sensor_transforms`
// Member `link_infos`
#include "geometry_msgs/msg/transform_stamped.h"
// Member `sensor_transforms`
// Member `link_infos`
#include "geometry_msgs/msg/transform_stamped__rosidl_typesupport_introspection_c.h"
// Member `joint_infos`
#include "halodi_msgs/msg/robot_joint_calibration_info.h"
// Member `joint_infos`
#include "halodi_msgs/msg/robot_joint_calibration_info__rosidl_typesupport_introspection_c.h"

#ifdef __cplusplus
extern "C"
{
#endif

void ExtrinsicCalibrationInfo__rosidl_typesupport_introspection_c__ExtrinsicCalibrationInfo_init_function(
  void * message_memory, enum rosidl_runtime_c_message_initialization _init)
{
  // TODO(karsten1987): initializers are not yet implemented for typesupport c
  // see https://github.com/ros2/ros2/issues/397
  (void) _init;
  halodi_msgs__msg__ExtrinsicCalibrationInfo__init(message_memory);
}

void ExtrinsicCalibrationInfo__rosidl_typesupport_introspection_c__ExtrinsicCalibrationInfo_fini_function(void * message_memory)
{
  halodi_msgs__msg__ExtrinsicCalibrationInfo__fini(message_memory);
}

size_t ExtrinsicCalibrationInfo__rosidl_typesupport_introspection_c__size_function__TransformStamped__sensor_transforms(
  const void * untyped_member)
{
  const geometry_msgs__msg__TransformStamped__Sequence * member =
    (const geometry_msgs__msg__TransformStamped__Sequence *)(untyped_member);
  return member->size;
}

const void * ExtrinsicCalibrationInfo__rosidl_typesupport_introspection_c__get_const_function__TransformStamped__sensor_transforms(
  const void * untyped_member, size_t index)
{
  const geometry_msgs__msg__TransformStamped__Sequence * member =
    (const geometry_msgs__msg__TransformStamped__Sequence *)(untyped_member);
  return &member->data[index];
}

void * ExtrinsicCalibrationInfo__rosidl_typesupport_introspection_c__get_function__TransformStamped__sensor_transforms(
  void * untyped_member, size_t index)
{
  geometry_msgs__msg__TransformStamped__Sequence * member =
    (geometry_msgs__msg__TransformStamped__Sequence *)(untyped_member);
  return &member->data[index];
}

bool ExtrinsicCalibrationInfo__rosidl_typesupport_introspection_c__resize_function__TransformStamped__sensor_transforms(
  void * untyped_member, size_t size)
{
  geometry_msgs__msg__TransformStamped__Sequence * member =
    (geometry_msgs__msg__TransformStamped__Sequence *)(untyped_member);
  geometry_msgs__msg__TransformStamped__Sequence__fini(member);
  return geometry_msgs__msg__TransformStamped__Sequence__init(member, size);
}

size_t ExtrinsicCalibrationInfo__rosidl_typesupport_introspection_c__size_function__TransformStamped__link_infos(
  const void * untyped_member)
{
  const geometry_msgs__msg__TransformStamped__Sequence * member =
    (const geometry_msgs__msg__TransformStamped__Sequence *)(untyped_member);
  return member->size;
}

const void * ExtrinsicCalibrationInfo__rosidl_typesupport_introspection_c__get_const_function__TransformStamped__link_infos(
  const void * untyped_member, size_t index)
{
  const geometry_msgs__msg__TransformStamped__Sequence * member =
    (const geometry_msgs__msg__TransformStamped__Sequence *)(untyped_member);
  return &member->data[index];
}

void * ExtrinsicCalibrationInfo__rosidl_typesupport_introspection_c__get_function__TransformStamped__link_infos(
  void * untyped_member, size_t index)
{
  geometry_msgs__msg__TransformStamped__Sequence * member =
    (geometry_msgs__msg__TransformStamped__Sequence *)(untyped_member);
  return &member->data[index];
}

bool ExtrinsicCalibrationInfo__rosidl_typesupport_introspection_c__resize_function__TransformStamped__link_infos(
  void * untyped_member, size_t size)
{
  geometry_msgs__msg__TransformStamped__Sequence * member =
    (geometry_msgs__msg__TransformStamped__Sequence *)(untyped_member);
  geometry_msgs__msg__TransformStamped__Sequence__fini(member);
  return geometry_msgs__msg__TransformStamped__Sequence__init(member, size);
}

size_t ExtrinsicCalibrationInfo__rosidl_typesupport_introspection_c__size_function__RobotJointCalibrationInfo__joint_infos(
  const void * untyped_member)
{
  const halodi_msgs__msg__RobotJointCalibrationInfo__Sequence * member =
    (const halodi_msgs__msg__RobotJointCalibrationInfo__Sequence *)(untyped_member);
  return member->size;
}

const void * ExtrinsicCalibrationInfo__rosidl_typesupport_introspection_c__get_const_function__RobotJointCalibrationInfo__joint_infos(
  const void * untyped_member, size_t index)
{
  const halodi_msgs__msg__RobotJointCalibrationInfo__Sequence * member =
    (const halodi_msgs__msg__RobotJointCalibrationInfo__Sequence *)(untyped_member);
  return &member->data[index];
}

void * ExtrinsicCalibrationInfo__rosidl_typesupport_introspection_c__get_function__RobotJointCalibrationInfo__joint_infos(
  void * untyped_member, size_t index)
{
  halodi_msgs__msg__RobotJointCalibrationInfo__Sequence * member =
    (halodi_msgs__msg__RobotJointCalibrationInfo__Sequence *)(untyped_member);
  return &member->data[index];
}

bool ExtrinsicCalibrationInfo__rosidl_typesupport_introspection_c__resize_function__RobotJointCalibrationInfo__joint_infos(
  void * untyped_member, size_t size)
{
  halodi_msgs__msg__RobotJointCalibrationInfo__Sequence * member =
    (halodi_msgs__msg__RobotJointCalibrationInfo__Sequence *)(untyped_member);
  halodi_msgs__msg__RobotJointCalibrationInfo__Sequence__fini(member);
  return halodi_msgs__msg__RobotJointCalibrationInfo__Sequence__init(member, size);
}

static rosidl_typesupport_introspection_c__MessageMember ExtrinsicCalibrationInfo__rosidl_typesupport_introspection_c__ExtrinsicCalibrationInfo_message_member_array[3] = {
  {
    "sensor_transforms",  // name
    rosidl_typesupport_introspection_c__ROS_TYPE_MESSAGE,  // type
    0,  // upper bound of string
    NULL,  // members of sub message (initialized later)
    true,  // is array
    255,  // array size
    true,  // is upper bound
    offsetof(halodi_msgs__msg__ExtrinsicCalibrationInfo, sensor_transforms),  // bytes offset in struct
    NULL,  // default value
    ExtrinsicCalibrationInfo__rosidl_typesupport_introspection_c__size_function__TransformStamped__sensor_transforms,  // size() function pointer
    ExtrinsicCalibrationInfo__rosidl_typesupport_introspection_c__get_const_function__TransformStamped__sensor_transforms,  // get_const(index) function pointer
    ExtrinsicCalibrationInfo__rosidl_typesupport_introspection_c__get_function__TransformStamped__sensor_transforms,  // get(index) function pointer
    ExtrinsicCalibrationInfo__rosidl_typesupport_introspection_c__resize_function__TransformStamped__sensor_transforms  // resize(index) function pointer
  },
  {
    "link_infos",  // name
    rosidl_typesupport_introspection_c__ROS_TYPE_MESSAGE,  // type
    0,  // upper bound of string
    NULL,  // members of sub message (initialized later)
    true,  // is array
    255,  // array size
    true,  // is upper bound
    offsetof(halodi_msgs__msg__ExtrinsicCalibrationInfo, link_infos),  // bytes offset in struct
    NULL,  // default value
    ExtrinsicCalibrationInfo__rosidl_typesupport_introspection_c__size_function__TransformStamped__link_infos,  // size() function pointer
    ExtrinsicCalibrationInfo__rosidl_typesupport_introspection_c__get_const_function__TransformStamped__link_infos,  // get_const(index) function pointer
    ExtrinsicCalibrationInfo__rosidl_typesupport_introspection_c__get_function__TransformStamped__link_infos,  // get(index) function pointer
    ExtrinsicCalibrationInfo__rosidl_typesupport_introspection_c__resize_function__TransformStamped__link_infos  // resize(index) function pointer
  },
  {
    "joint_infos",  // name
    rosidl_typesupport_introspection_c__ROS_TYPE_MESSAGE,  // type
    0,  // upper bound of string
    NULL,  // members of sub message (initialized later)
    true,  // is array
    255,  // array size
    true,  // is upper bound
    offsetof(halodi_msgs__msg__ExtrinsicCalibrationInfo, joint_infos),  // bytes offset in struct
    NULL,  // default value
    ExtrinsicCalibrationInfo__rosidl_typesupport_introspection_c__size_function__RobotJointCalibrationInfo__joint_infos,  // size() function pointer
    ExtrinsicCalibrationInfo__rosidl_typesupport_introspection_c__get_const_function__RobotJointCalibrationInfo__joint_infos,  // get_const(index) function pointer
    ExtrinsicCalibrationInfo__rosidl_typesupport_introspection_c__get_function__RobotJointCalibrationInfo__joint_infos,  // get(index) function pointer
    ExtrinsicCalibrationInfo__rosidl_typesupport_introspection_c__resize_function__RobotJointCalibrationInfo__joint_infos  // resize(index) function pointer
  }
};

static const rosidl_typesupport_introspection_c__MessageMembers ExtrinsicCalibrationInfo__rosidl_typesupport_introspection_c__ExtrinsicCalibrationInfo_message_members = {
  "halodi_msgs__msg",  // message namespace
  "ExtrinsicCalibrationInfo",  // message name
  3,  // number of fields
  sizeof(halodi_msgs__msg__ExtrinsicCalibrationInfo),
  ExtrinsicCalibrationInfo__rosidl_typesupport_introspection_c__ExtrinsicCalibrationInfo_message_member_array,  // message members
  ExtrinsicCalibrationInfo__rosidl_typesupport_introspection_c__ExtrinsicCalibrationInfo_init_function,  // function to initialize message memory (memory has to be allocated)
  ExtrinsicCalibrationInfo__rosidl_typesupport_introspection_c__ExtrinsicCalibrationInfo_fini_function  // function to terminate message instance (will not free memory)
};

// this is not const since it must be initialized on first access
// since C does not allow non-integral compile-time constants
static rosidl_message_type_support_t ExtrinsicCalibrationInfo__rosidl_typesupport_introspection_c__ExtrinsicCalibrationInfo_message_type_support_handle = {
  0,
  &ExtrinsicCalibrationInfo__rosidl_typesupport_introspection_c__ExtrinsicCalibrationInfo_message_members,
  get_message_typesupport_handle_function,
};

ROSIDL_TYPESUPPORT_INTROSPECTION_C_EXPORT_halodi_msgs
const rosidl_message_type_support_t *
ROSIDL_TYPESUPPORT_INTERFACE__MESSAGE_SYMBOL_NAME(rosidl_typesupport_introspection_c, halodi_msgs, msg, ExtrinsicCalibrationInfo)() {
  ExtrinsicCalibrationInfo__rosidl_typesupport_introspection_c__ExtrinsicCalibrationInfo_message_member_array[0].members_ =
    ROSIDL_TYPESUPPORT_INTERFACE__MESSAGE_SYMBOL_NAME(rosidl_typesupport_introspection_c, geometry_msgs, msg, TransformStamped)();
  ExtrinsicCalibrationInfo__rosidl_typesupport_introspection_c__ExtrinsicCalibrationInfo_message_member_array[1].members_ =
    ROSIDL_TYPESUPPORT_INTERFACE__MESSAGE_SYMBOL_NAME(rosidl_typesupport_introspection_c, geometry_msgs, msg, TransformStamped)();
  ExtrinsicCalibrationInfo__rosidl_typesupport_introspection_c__ExtrinsicCalibrationInfo_message_member_array[2].members_ =
    ROSIDL_TYPESUPPORT_INTERFACE__MESSAGE_SYMBOL_NAME(rosidl_typesupport_introspection_c, halodi_msgs, msg, RobotJointCalibrationInfo)();
  if (!ExtrinsicCalibrationInfo__rosidl_typesupport_introspection_c__ExtrinsicCalibrationInfo_message_type_support_handle.typesupport_identifier) {
    ExtrinsicCalibrationInfo__rosidl_typesupport_introspection_c__ExtrinsicCalibrationInfo_message_type_support_handle.typesupport_identifier =
      rosidl_typesupport_introspection_c__identifier;
  }
  return &ExtrinsicCalibrationInfo__rosidl_typesupport_introspection_c__ExtrinsicCalibrationInfo_message_type_support_handle;
}
#ifdef __cplusplus
}
#endif
