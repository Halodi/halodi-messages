// generated from rosidl_generator_cpp/resource/idl__struct.hpp.em
// with input from halodi_msgs:msg/DrivingTrajectory.idl
// generated code does not contain a copyright notice

#ifndef HALODI_MSGS__MSG__DRIVING_TRAJECTORY__STRUCT_HPP_
#define HALODI_MSGS__MSG__DRIVING_TRAJECTORY__STRUCT_HPP_

#include <rosidl_generator_cpp/bounded_vector.hpp>
#include <rosidl_generator_cpp/message_initialization.hpp>
#include <algorithm>
#include <array>
#include <memory>
#include <string>
#include <vector>


// Include directives for member types
// Member 'trajectory_points'
#include "halodi_msgs/msg/driving_trajectory_point__struct.hpp"

#ifndef _WIN32
# define DEPRECATED__halodi_msgs__msg__DrivingTrajectory __attribute__((deprecated))
#else
# define DEPRECATED__halodi_msgs__msg__DrivingTrajectory __declspec(deprecated)
#endif

namespace halodi_msgs
{

namespace msg
{

// message struct
template<class ContainerAllocator>
struct DrivingTrajectory_
{
  using Type = DrivingTrajectory_<ContainerAllocator>;

  explicit DrivingTrajectory_(rosidl_generator_cpp::MessageInitialization _init = rosidl_generator_cpp::MessageInitialization::ALL)
  {
    if (rosidl_generator_cpp::MessageInitialization::ALL == _init ||
      rosidl_generator_cpp::MessageInitialization::ZERO == _init)
    {
      this->look_ahead_distance = 0.0;
      this->K = 0.0;
    }
  }

  explicit DrivingTrajectory_(const ContainerAllocator & _alloc, rosidl_generator_cpp::MessageInitialization _init = rosidl_generator_cpp::MessageInitialization::ALL)
  {
    (void)_alloc;
    if (rosidl_generator_cpp::MessageInitialization::ALL == _init ||
      rosidl_generator_cpp::MessageInitialization::ZERO == _init)
    {
      this->look_ahead_distance = 0.0;
      this->K = 0.0;
    }
  }

  // field types and members
  using _look_ahead_distance_type =
    double;
  _look_ahead_distance_type look_ahead_distance;
  using _K_type =
    double;
  _K_type K;
  using _trajectory_points_type =
    std::vector<halodi_msgs::msg::DrivingTrajectoryPoint_<ContainerAllocator>, typename ContainerAllocator::template rebind<halodi_msgs::msg::DrivingTrajectoryPoint_<ContainerAllocator>>::other>;
  _trajectory_points_type trajectory_points;

  // setters for named parameter idiom
  Type & set__look_ahead_distance(
    const double & _arg)
  {
    this->look_ahead_distance = _arg;
    return *this;
  }
  Type & set__K(
    const double & _arg)
  {
    this->K = _arg;
    return *this;
  }
  Type & set__trajectory_points(
    const std::vector<halodi_msgs::msg::DrivingTrajectoryPoint_<ContainerAllocator>, typename ContainerAllocator::template rebind<halodi_msgs::msg::DrivingTrajectoryPoint_<ContainerAllocator>>::other> & _arg)
  {
    this->trajectory_points = _arg;
    return *this;
  }

  // constant declarations

  // pointer types
  using RawPtr =
    halodi_msgs::msg::DrivingTrajectory_<ContainerAllocator> *;
  using ConstRawPtr =
    const halodi_msgs::msg::DrivingTrajectory_<ContainerAllocator> *;
  using SharedPtr =
    std::shared_ptr<halodi_msgs::msg::DrivingTrajectory_<ContainerAllocator>>;
  using ConstSharedPtr =
    std::shared_ptr<halodi_msgs::msg::DrivingTrajectory_<ContainerAllocator> const>;

  template<typename Deleter = std::default_delete<
      halodi_msgs::msg::DrivingTrajectory_<ContainerAllocator>>>
  using UniquePtrWithDeleter =
    std::unique_ptr<halodi_msgs::msg::DrivingTrajectory_<ContainerAllocator>, Deleter>;

  using UniquePtr = UniquePtrWithDeleter<>;

  template<typename Deleter = std::default_delete<
      halodi_msgs::msg::DrivingTrajectory_<ContainerAllocator>>>
  using ConstUniquePtrWithDeleter =
    std::unique_ptr<halodi_msgs::msg::DrivingTrajectory_<ContainerAllocator> const, Deleter>;
  using ConstUniquePtr = ConstUniquePtrWithDeleter<>;

  using WeakPtr =
    std::weak_ptr<halodi_msgs::msg::DrivingTrajectory_<ContainerAllocator>>;
  using ConstWeakPtr =
    std::weak_ptr<halodi_msgs::msg::DrivingTrajectory_<ContainerAllocator> const>;

  // pointer types similar to ROS 1, use SharedPtr / ConstSharedPtr instead
  // NOTE: Can't use 'using' here because GNU C++ can't parse attributes properly
  typedef DEPRECATED__halodi_msgs__msg__DrivingTrajectory
    std::shared_ptr<halodi_msgs::msg::DrivingTrajectory_<ContainerAllocator>>
    Ptr;
  typedef DEPRECATED__halodi_msgs__msg__DrivingTrajectory
    std::shared_ptr<halodi_msgs::msg::DrivingTrajectory_<ContainerAllocator> const>
    ConstPtr;

  // comparison operators
  bool operator==(const DrivingTrajectory_ & other) const
  {
    if (this->look_ahead_distance != other.look_ahead_distance) {
      return false;
    }
    if (this->K != other.K) {
      return false;
    }
    if (this->trajectory_points != other.trajectory_points) {
      return false;
    }
    return true;
  }
  bool operator!=(const DrivingTrajectory_ & other) const
  {
    return !this->operator==(other);
  }
};  // struct DrivingTrajectory_

// alias to use template instance with default allocator
using DrivingTrajectory =
  halodi_msgs::msg::DrivingTrajectory_<std::allocator<void>>;

// constant definitions

}  // namespace msg

}  // namespace halodi_msgs

#endif  // HALODI_MSGS__MSG__DRIVING_TRAJECTORY__STRUCT_HPP_
